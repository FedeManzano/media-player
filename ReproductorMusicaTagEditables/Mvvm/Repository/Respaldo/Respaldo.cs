using System;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ReproductorMusicaTagEditables.Mvvm.Repository.Respaldo
{
    public class Respaldo
    {
        private static readonly string RAIZ = Environment.CurrentDirectory;

        public static void CrearRespaldo()
        {
            FolderBrowserDialog fs = new FolderBrowserDialog();
            if(fs.ShowDialog() == DialogResult.OK)
            {
                string nombreBackUp = $"Respaldo-{DateTime.Now:dd-MM-yyyy}";


                if(!string.IsNullOrEmpty(nombreBackUp) )
                {
                    Directory.CreateDirectory(RAIZ + "/" + nombreBackUp);
                    GuardarElemento(RAIZ + "/" + nombreBackUp, "Listas");
                    GuardarElemento(RAIZ + "/" + nombreBackUp, "Historial");
                    GuardarElemento(RAIZ + "/" + nombreBackUp, "Listas/Regalos");
                    GuardarElemento(RAIZ + "/" + nombreBackUp, "Usuario");

                    if (File.Exists(RAIZ + "/Canciones.json"))
                    {
                        File.Copy(RAIZ + "/Canciones.json", RAIZ + "/" + nombreBackUp + "/" + "Canciones.json", true);
                    }

                    if(File.Exists(fs.SelectedPath + "/" + nombreBackUp + ".zip"))
                    {
                        File.Delete(fs.SelectedPath + "/" + nombreBackUp + ".zip");
                    }

                    if(ZipearArchivo(RAIZ + "/" + nombreBackUp, fs.SelectedPath, nombreBackUp))
                    {
                        System.Windows.Forms.MessageBox.Show($"Pude encontrar el archivo [.zip] de respaldo en {fs.SelectedPath}.", "Respaldo exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show($"El archivo de respaldo no fue creado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }               
            } 
        }

        public static void CargarRespaldo()
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Archivos ZIP(*.zip)| *.zip";
            if (of.ShowDialog() == DialogResult.OK)
            {
                if (ComprovarHashes(of.FileName))
                {
                    Directory.CreateDirectory(RAIZ + "/temp");
                    ZipFile.ExtractToDirectory(of.FileName, RAIZ +"/temp");
                    ReemplazarElementos(RAIZ + "/temp", "Listas");
                    ReemplazarElementos(RAIZ + "/temp", "Historial");
                    ReemplazarElementos(RAIZ + "/temp", "Listas/Regalos");
                    ReemplazarElementos(RAIZ + "/temp", "Usuario");

                    File.Copy(RAIZ + "/temp/" + "Canciones.json", RAIZ + "/Canciones.json", true);
                    Directory.Delete(RAIZ + "/temp", true);

                    System.Windows.Forms.MessageBox.Show($"Se han recuperado de manea exitosa los archivos del respaldo.", "Recuperación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show($"Archivo de respaldo corrupto no puede recuperarse.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private static void ReemplazarElementos(string pathTemporal, string elementoDirectorio)
        {
            if(Directory.Exists(pathTemporal + "/" + elementoDirectorio)) 
            {
                if (!Directory.Exists(RAIZ + "/" + elementoDirectorio))
                    Directory.CreateDirectory(RAIZ + "/" + elementoDirectorio);
                else
                {
                    foreach(string e in Directory.GetFiles(RAIZ + "/" + elementoDirectorio))
                    {
                        File.Delete(e);
                    }
                    string[] elementos = Directory.GetFiles(pathTemporal + "/" + elementoDirectorio);
                    foreach (string p in elementos)
                    {
                        FileInfo fi = new FileInfo(p);
                        File.Copy(p, RAIZ + "/" + elementoDirectorio + "/" + fi.Name);
                    }
                }
            }
        }

        private static bool ComprovarHashes(string pathArchivo)
        {
            string hash = CalculateFileHash(pathArchivo);
            string nombreHash = LevantarHashArchivo(pathArchivo);
            return hash == nombreHash;
        }

        private static string LevantarHashArchivo(string archivoPath)
        {
            FileInfo fileInfo = new FileInfo(archivoPath);

            string nombre = Path.GetFileNameWithoutExtension(fileInfo.FullName);

            if(nombre.Split('-').Length == 5)
            {
                return nombre.Split('-')[4];
            }
            return "";
        }

        private static bool ZipearArchivo(string directoroBackUp, string directorioSalida, string nombreArchivo)
        {
            if(Directory.Exists(directoroBackUp) && Directory.Exists(directorioSalida))
            {
                ZipFile.CreateFromDirectory(directoroBackUp, directoroBackUp + ".zip");
                if(File.Exists(directoroBackUp + ".zip"))
                {
                    string h = CalculateFileHash(directoroBackUp + ".zip");
                    File.Copy(directoroBackUp + ".zip", directorioSalida + "/" + nombreArchivo + $"-{h}" + ".zip");
                    File.Delete(directoroBackUp + ".zip");
                    Directory.Delete(directoroBackUp, true);
                    return true;
                }
                return false;
            }
            return false;
        }

        private static void GuardarElemento(string directorioRespaldo, string elementoInterno)
        {
            if (Directory.Exists(directorioRespaldo))
            {
                if (Directory.Exists(RAIZ + "/" + elementoInterno))
                {
                    Directory.CreateDirectory(directorioRespaldo + "/" + elementoInterno);
                    string[] paths = Directory.GetFiles(RAIZ + "/" + elementoInterno);
                    foreach (string p in paths)
                    {
                        FileInfo fi = new FileInfo(p);
                        string n = fi.Name;
                        File.Copy(p, directorioRespaldo + $"/{elementoInterno}/" + n, true);
                    }
                }
            }
        }

        public static string CalculateFileHash(string filename)
        {
            HashAlgorithm hash = MD5.Create("MD5");
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            string resul = ArrayToString(hash.ComputeHash(fs));
            fs.Close();
            return resul;
        }

        private static string ArrayToString(byte[] byteArray)
        {
            
            StringBuilder sb = new StringBuilder(byteArray.Length);
            for (int i = 0; i < byteArray.Length; i++)
            {
                sb.Append(byteArray[i].ToString("X2"));
            }

            return sb.ToString();
        }
    }
}
