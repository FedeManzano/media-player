﻿
using ReproductorMusicaTagEditables.Mvvm.ExtensionMetodos;
using ReproductorMusicaTagEditables.Mvvm.Model;
using ReproductorMusicaTagEditables.Mvvm.Repository.Listas;
using ReproductorMusicaTagEditables.Mvvm.ViewModel.Base;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Forms;

namespace ReproductorMusicaTagEditables.Mvvm.VentanasUtilitarias
{
    public partial class AgregarCancionesListas : Window, INotifyPropertyChanged
    {
        private ReproductorViewModelBase reproductorViewModelBase;
        private List<Cancion> listadoCancionesAgregar = new List<Cancion>();
        private bool fallos = false;

        public List<Cancion> ListadoCancionesAgregar 
        { 
            get => listadoCancionesAgregar;
            set 
            { 
                listadoCancionesAgregar = value;
                OnPropertyChange(nameof(ListadoCancionesAgregar));
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChange(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public AgregarCancionesListas(ReproductorViewModelBase reproductorViewModel)
        {
            InitializeComponent();
            this.reproductorViewModelBase = reproductorViewModel;
            lstAgregar.ItemsSource = ListadoCancionesAgregar;
        }

        public bool AgregarCancion(Cancion c)
        {
            List<string> l = ListasReproduccion.ListadoNombres();
            if(l.Count == 0)
            {
                
                MostrarMensajeError("No hay listas de reproducciones creadas. Dirijase a la opción 'Mis listas' del menú lateral.");
                Hide();
                return false;
            }
            ListadoCancionesAgregar = new List<Cancion>() { c };
            lstAgregar.ItemsSource = ListadoCancionesAgregar;
            lstListasRepro.ItemsSource = l;
          
            return true;
            
        }

        public bool AgregarListaCanciones(List<Cancion> lista)
        {
            List<string> l = ListasReproduccion.ListadoNombres();
            if (l.Count == 0)
            {
                MostrarMensajeError("No hay listas de reproducciones creadas. Dirijase a la opción 'Mis listas' del menú lateral.");
                Hide();
                return false;
            }
          
            ListadoCancionesAgregar = new List<Cancion>(lista);
            lstAgregar.ItemsSource= ListadoCancionesAgregar;
            lstListasRepro.ItemsSource = l;
            return true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(lstListasRepro.Items.Count > 0 && lstListasRepro.SelectedIndex < 0)
            {
                MostrarMensajeError($"Para poder cargar canciones a una determinada lista debe seleccionarla primero. Desde el panel que está a su izquierda con los nombres de las listas existentes.");
                return;
            }

            if(lstAgregar.Items.Count > 0)
            {
                lstAgregar.SelectAll();

                ListadoCancionesAgregar.ForEach(c =>
                {

                    Cancion cl = BuscarCancion(c);
                    if (cl.Titulo == c.Titulo)
                    {
                        if (lstListasRepro.Items.Count > 0)
                        {
                            if (lstListasRepro.SelectedIndex < 0)
                            {
                                fallos = true;
                            } else
                            {
                                ListasReproduccion.AgregarCancion(lstListasRepro.Items[lstListasRepro.SelectedIndex].ToString(), cl);
                            }
                        }
                    }
                });
            }
            if(fallos)
            {
                MostrarMensajeError("Algunas o todas las pistas no pudieron agregarse a la lista seleccionada. Motivo: Probablemente ya se encuentren en la lista.");
            }
            else
            {
                MostrarMensajeInfo("Las Canciones seleccionadas Fueron agregadas a la lista seleccionada.");
                
            }

            Salir();
        }

        private void Salir()
        {
            fallos = false;
            Hide();
        }


        private Cancion BuscarCancion(Cancion cancion)
        {
            List<Cancion> li = reproductorViewModelBase.Irg.Canciones.Where(cl => cl.Titulo == cancion.Titulo && cl.Album == cancion.Album).ToList();
            return li.Count > 0 ? li[0]:null;
        }


        public void MostrarMensajeInfo(string mje)
        {
            System.Windows.Forms.MessageBox.Show(mje,"Ingreso de canciones",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public void MostrarMensajeError (string mje)
        {
            System.Windows.Forms.MessageBox.Show(mje, "Ingreso de canciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Salir();
        }
    }
}
