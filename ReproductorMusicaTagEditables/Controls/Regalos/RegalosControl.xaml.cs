using ReproductorMusicaTagEditables.Mvvm.Repository.Listas;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;

namespace ReproductorMusicaTagEditables.Controls.Regalos
{
    public partial class RegalosControl : System.Windows.Controls.UserControl
    {


        public static DependencyProperty ImagenUnoProperty =
            DependencyProperty.Register("ImagenUno", typeof(ImageBrush), typeof(RegalosControl), new PropertyMetadata(null));

        public ImageBrush ImagenUno
        {
            get => (ImageBrush) GetValue(ImagenUnoProperty);
            set => SetValue(ImagenUnoProperty, value);
        }

        #region Imagenes
        public static DependencyProperty ImagenDosProperty =
            DependencyProperty.Register("ImagenDos", typeof(ImageBrush), typeof(RegalosControl), new PropertyMetadata(null));

        public ImageBrush ImagenDos
        {
            get => (ImageBrush)GetValue(ImagenDosProperty);
            set => SetValue(ImagenDosProperty, value);
        }


        public static DependencyProperty ImagenTresProperty =
            DependencyProperty.Register("ImagenTres", typeof(ImageBrush), typeof(RegalosControl), new PropertyMetadata(null));

        public ImageBrush ImagenTres
        {
            get => (ImageBrush)GetValue(ImagenTresProperty);
            set => SetValue(ImagenTresProperty, value);
        }


        public static DependencyProperty ImagenCuatroProperty =
            DependencyProperty.Register("ImagenCuatro", typeof(ImageBrush), typeof(RegalosControl), new PropertyMetadata(null));

        public ImageBrush ImagenCuatro
        {
            get => (ImageBrush)GetValue(ImagenCuatroProperty);
            set => SetValue(ImagenCuatroProperty, value);
        }
        #endregion

        #region Fondo
        public static DependencyProperty ColorFondoProperty =
          DependencyProperty.Register("ColorFondo", typeof(string), typeof(RegalosControl), new PropertyMetadata(string.Empty));

        public string ColorFondo
        {
            get => (string) GetValue(ColorFondoProperty);
            set => SetValue(ColorFondoProperty, value);
        }
        #endregion 

        public static DependencyProperty TextoProperty =
          DependencyProperty.Register("Texto", typeof(string), typeof(RegalosControl), new PropertyMetadata(string.Empty));

        public string Texto
        {
            get => (string)GetValue(TextoProperty);
            set => SetValue(TextoProperty, value);
        }

        public RegalosControl()
        {
            InitializeComponent();
        }

        private void Eliminar_Regalo(object sender, RoutedEventArgs e)
        {
            string fechaRegalo = Texto.DameConFormatoFecha();
            if (fechaRegalo.EsUnRegalo())
            {
                DialogResult res = System.Windows.Forms.MessageBox.Show($"Está seguro que desea eliminar el regalo {Texto} ?.", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    ListasReproduccion.BorrarRegalo(fechaRegalo);
                    System.Windows.Forms.MessageBox.Show($"El regalo {Texto} fue eliminado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
