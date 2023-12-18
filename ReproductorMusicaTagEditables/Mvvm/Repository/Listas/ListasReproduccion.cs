﻿using Newtonsoft.Json;
using ReproductorMusicaTagEditables.Mvvm.ExtensionMetodos;
using ReproductorMusicaTagEditables.Mvvm.Model;
using ReproductorMusicaTagEditables.Mvvm.ViewModel.Base.Info;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;

namespace ReproductorMusicaTagEditables.Mvvm.Repository.Listas
{
    public  class ListasReproduccion
    {

        public static readonly string PATH_LISTAS = Environment.CurrentDirectory +  @"/Listas/";
        public static readonly string PATH_REGALOS = PATH_LISTAS+"Regalos/";
        public static readonly string EXT = ".json";

        private static void CrearDirectorio()
        {
            try
            {
                Directory.CreateDirectory(PATH_LISTAS);
            }
            catch
            {

            }
        }

        public static bool ValidarNombre(string nombreLista)
        {
            if (string.IsNullOrEmpty(nombreLista)) return false;  
            return Regex.IsMatch(nombreLista, "^([a-zA-Z0-9-_ ]{3,25})$");
        }

        public static bool ExisteLista(string nombreLista)
        {
            try
            {
                if (!Directory.Exists(PATH_LISTAS))
                    CrearDirectorio();
                if (string.IsNullOrEmpty(nombreLista)) { return false; }
            }
            catch
            {

            }
            return File.Exists(nombreLista.Ruta());
        }

        public static bool Crear(string nombreLista)
        {
            try
            {
                if (!Directory.Exists(PATH_LISTAS))
                    CrearDirectorio();
                if (string.IsNullOrEmpty(nombreLista)) return false;
                if (ExisteLista(nombreLista)) return false;
                if (!ValidarNombre(nombreLista)) return false;

                File.Create(nombreLista.Ruta()).Close();
            }
            catch
            {
                return false;
            }
            
            return true;
        }

        public static bool Borrar(string nombreLista)
        {
            try
            {
                if (string.IsNullOrEmpty(nombreLista))
                    if (ExisteLista(nombreLista))
                        return false;
                File.Delete(nombreLista.Ruta());
            }
            catch
            {

            }
            return true;
        }

        public static List<string> ListadoNombres()
        {
            try
            {
                if (!Directory.Exists(PATH_LISTAS))
                    CrearDirectorio();
                string[] archivos = Directory.GetFiles(PATH_LISTAS);
                if (archivos.Length == 0)
                    return new List<string>();
                List<string> nombresListas = archivos.Where(s =>
                {
                    FileInfo fi = new FileInfo(s);
                    if (Path.GetFileNameWithoutExtension(fi.Name) != "FAVORITOS")
                    {
                        string e = fi.Extension;
                        if (e != EXT) return false;
                        return true;
                    }
                    return false;
                }).Select(s => Path.GetFileNameWithoutExtension(s)).ToList();
                return nombresListas;
            }
            catch
            {
                return new List<string>();
            }
        }

        public static bool AgregarCancion(string nombreLista, Cancion c)
        {  
            if(string.IsNullOrEmpty(nombreLista)) return false;
            if(c == null) return false;
            if(c.Artista == "Desconocido" || c.Album == "Desconocido")
            {
                if(nombreLista != "FAVORITOS")
                {
                    System.Windows.Forms.MessageBox.Show($"No puede agregarse la cancion: {c.Titulo} a la lista {nombreLista} porque la canción no posee los metadatos adecuados. Puede editarlos desde el botón tags de la página principal.", "Error", System.Windows.Forms.MessageBoxButtons.OK, (System.Windows.Forms.MessageBoxIcon)MessageBoxImage.Information);
                    return false;
                }
            }

            if(!ExisteLista(nombreLista)) return false;

            try
            {
                List<Cancion> listado = nombreLista.Ruta().ObtenerListadoReproduccion();
                listado = AgregarYBlanquearCanciones(listado, c);
                listado.GuardarListado(nombreLista.Ruta());
            }
            catch
            {
                return false;
            }
            

            return true;
        }

        private static bool LaMismaCancion(Cancion c1, Cancion c2)
        {
            return c1.Titulo == c2.Titulo && c1.Artista == c2.Artista && c1.Album == c2.Album;
        }

        public static bool RemoverCancion(string nombreLista, Cancion c)
        {
            if (string.IsNullOrEmpty(nombreLista)) return false;
            if (c == null) return false;
            if (!ExisteLista(nombreLista)) return false;

            List<Cancion> listado = nombreLista.ObtenerListadoReproduccion();
            listado = listado.Where(cl => !LaMismaCancion(cl,c)).ToList();
          
            try
            {
                listado.GuardarListado(nombreLista.Ruta());
            }
            catch
            {
                return false;
            }

            
            return true;
        }

        public static List<Cancion> DameListadoCanciones (string nombreLista)
        {
            if (string.IsNullOrEmpty(nombreLista)) return new List<Cancion>();

            if (nombreLista.EsUnRegalo())
            {
                if(File.Exists(PATH_REGALOS + nombreLista + ".json"))
                {
                    List<Cancion> l = DameListadoRegalo(nombreLista);
                    return l;
                }
            }

            if (!ExisteLista(nombreLista)) return new List<Cancion>();

            try
            {
                List<Cancion> listado = nombreLista.Ruta().ObtenerListadoReproduccion();
        
                if(listado != null)
                {
                    listado = listado.BlanquearListado();
                    return listado;
                }
                return new List<Cancion>();
            }
            catch
            {
                return new List<Cancion>();
            }
        }

        public static string CalcularDuracionLista(string nombreLista)
        {
            List<Cancion> l = DameListadoCanciones(nombreLista);
            return l.DuracionString();
        }

        public static string FechaCreacion(string nombreLista)
        {
            if(ExisteLista(nombreLista))
            {
                return File.GetCreationTime(nombreLista.Ruta()).ToString(@"dd/MM/yyyy");
            }
            return string.Empty;
        }

        public static void CrearListaFavoritos()
        {
            Crear("FAVORITOS");
        }

        public static bool ActualizarListaReproduccion (string nombreLista)
        {
            if(string.IsNullOrEmpty(nombreLista) && !ExisteLista(nombreLista))
                return false;
            List<Cancion> cancions = nombreLista.Ruta().ObtenerListadoReproduccion();

            InfoReproductor i = InfoReproductor.DameInstancia();
            List<Cancion> res = new List<Cancion> ();
            foreach(Cancion c in i.Canciones)
            {
                foreach (Cancion cl in cancions)
                {
                    if(cl.Path == c.Path)
                    {
                        if (c.Equals(i.CancionActual.Cancion))
                        {
                            c.EstadoColor = i.CancionActual.Cancion.EstadoColor;
                        }
                        else c.EstadoColor = "White";

                        c.Cantidad = cl.Cantidad;
                        res.Add(c);
                    }    
                }
            }
            if(nombreLista == "FAVORITOS")
            {
                res = res.OrdenarPorCantidadDecreciente();
            }
            res.GuardarListado(nombreLista.Ruta());
            
            return true;
        }
        public static bool AgregarCancionAFavoritos(Cancion c)
        {
            if(c == null) return false;

            if (!ExisteLista("FAVORITOS"))
            {
                Crear("FAVORITOS");
            }
            if(c.Artista != "Desconocido" && c.Album != "Desconocido")
            {
                List<Cancion> listaCanciones = "FAVORITOS".Ruta().ObtenerListadoReproduccion();

                listaCanciones.ForEach(cl =>
                {
                    if (cl.Equals(c))
                    {
                        c.Cantidad = cl.Cantidad;
                    }
                });

                c.Cantidad++;
                c.UltimaReproduccion = DateTime.Now;
        
                
                listaCanciones = AgregarYBlanquearCanciones(listaCanciones, c);
                listaCanciones = listaCanciones.OrdenarPorCantidadDecreciente();

                try
                {
                    listaCanciones.GuardarListado("FAVORITOS".Ruta());
                    AgregarCancionRegalo(c);
                }
                catch
                {
                    
                }
            }
            return false;
        }
        
        #region Regalos
        public static Dictionary<string,List<Cancion>> GenerarListasDinamicasFavoritos ()
        {
            Dictionary<string, List<Cancion>> dicCanciones = new Dictionary<string, List<Cancion>>();
            if (!Directory.Exists(PATH_REGALOS))
                Directory.CreateDirectory(PATH_REGALOS);
            string[] paths = Directory.GetFiles(PATH_REGALOS);

            foreach(string p in paths)
            {
                string nombre = ExtraerNombreArchivo(p);
                //if (EsMenorQueLAFechaActual(nombre))
                //{
                    List<Cancion> l = JsonConvert.DeserializeObject<List<Cancion>>(File.ReadAllText(p));
                    if (l != null && l.Any())
                    {
                        dicCanciones[nombre] = l;
                    }
                //}
            }
            return dicCanciones;
        }

        public static List<Cancion> DameListadoRegalo(string nombreLista)
        {
            nombreLista = nombreLista.DameConFormatoFecha();
            InfoReproductor i = InfoReproductor.DameInstancia();
            string[] paths = Directory.GetFiles(PATH_REGALOS);
            foreach(var p in paths)
            {
                string nombre = ExtraerNombreArchivo(p);
                
                if(nombreLista == nombre)
                {
                    List<Cancion> l = JsonConvert.DeserializeObject<List<Cancion>>(File.ReadAllText(p));
                    if (l != null)
                    {
                        if (l.Count > 50)
                        {
                            l = l.GetRange(0, 50).BlanquearListado();
                            l.GuardarListado(p);
                        }
                        return l;
                    }
                        
                    else return new List<Cancion>();
                }
            }
            return new List<Cancion>();
        }

        public static List<Cancion> DameListatoFavoritos()
        {
            try
            {
                List<Cancion> listaFav = "FAVORITOS".Ruta().ObtenerListadoReproduccion();
                if(listaFav != null)
                {
                    return listaFav.BlanquearListado();
                }
                return  new List<Cancion>();
            }
            catch
            {
                return new List<Cancion>();
            }
        }
        
        public static void AgregarCancionRegalo(Cancion c)
        {
            if(!Directory.Exists(PATH_REGALOS))
            {
                Directory.CreateDirectory(PATH_REGALOS);
            }

            string[] paths = Directory.GetFiles(PATH_REGALOS);


            string nombre = c.ConvertirFecha();
            string nombreArchivoSeleccionado = "";
            string pathSeleccionado = "";
           

            foreach (string p in paths)
            {
                string na = ExtraerNombreArchivo(p);
                if(na == nombre)
                {
                    nombreArchivoSeleccionado = na;
                    pathSeleccionado = p;
                }
                
            }

            if (!string.IsNullOrEmpty(nombreArchivoSeleccionado))
            {
                List<Cancion> listadoCanciones = pathSeleccionado.ObtenerListadoReproduccion();
                listadoCanciones = AgregarYBlanquearCanciones(listadoCanciones, c);
                listadoCanciones = listadoCanciones.OrdenarPorCantidadDecreciente();
                listadoCanciones.GuardarListado(pathSeleccionado);
            }
            else
            {
                List<Cancion> l = new List<Cancion> { c };
                l.GuardarListado(PATH_REGALOS + nombre + EXT);
            }
        }
        
        public static string ExtraerNombreArchivo(string path)
        {
            if (File.Exists(path))
            {
                FileInfo fi = new FileInfo(path);
                return Path.GetFileNameWithoutExtension(fi.FullName);
            }
            return "";
        } 

        public static bool EsMenorQueLAFechaActual(string fecha)
        {
            if(fecha == null)
                return false;
            if(fecha.ValidarFormato())
            {
                DateTime dateTime = DateTime.Now;
                string mes = fecha.MesString();
                string ano = fecha.AnoString();

                try
                {
                    int anoInt = int.Parse(ano);
                    int mesInt = int.Parse(mes);

                    if (dateTime.Year > anoInt)
                        return true;
                    else if (dateTime.Year == anoInt)
                    {
                        if(dateTime.Month > mesInt) 
                            return true;
                    } 
                    return false;
                }
                catch
                {
                    return false;
                }
            }

            return false;
        }

        public static string FechaCreacionDelRegalo(string nombre)
        {
            nombre = nombre.DameConFormatoFecha();
            if (File.Exists(PATH_REGALOS + nombre + EXT))
            {
                return File.GetCreationTime(PATH_REGALOS + nombre + EXT).ToString(@"dd/MM/yyyy");
            }
            return "00/00/0000";
        }

        private static List<Cancion> AgregarYBlanquearCanciones(List<Cancion> listado, Cancion c)
        {
            listado = listado.BlanquearListado(c);
            if(!listado.Exists(cl => cl.Equals(c)))
                listado.Add(c);
            return listado;
        }

        public static bool BorrarRegalo(string nombreRegalo)
        {
            nombreRegalo = nombreRegalo.DameConFormatoFecha();
            if(File.Exists(PATH_REGALOS + nombreRegalo + EXT))
            {
                File.Delete(PATH_REGALOS + nombreRegalo + EXT);
                return true;
            }
            return false;
        }
        #endregion
    }
}
