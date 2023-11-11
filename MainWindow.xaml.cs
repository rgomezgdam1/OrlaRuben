using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OrlaRuben
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MouseClick41(object sender, RoutedEventArgs e)
        {
            Puesto41.Text = "acuadraara1@educacion.navarra.es";
        }

        private void MouseEnter41(object sender, MouseEventArgs e)
        {
            Puesto41.Text = "Aitor Cuadrado";
        }

        private void MouseLeave41(object sender, MouseEventArgs e)
        {
            Puesto41.Text = "";
        }

        private void MouseClick42(object sender, RoutedEventArgs e)
        {
            Puesto42.Text = "jtrigosier1@educacion.navarra.es";
        }

        private void MouseEnter42(object sender, MouseEventArgs e)
        {
            Puesto42.Text = "Joseba Trigo";
        }

        private void MouseLeave42(object sender, MouseEventArgs e)
        {
            Puesto42.Text = "";
        }

        private void Persona41_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Profile win2 = new Profile("Nombre", "Apellidos", "email alumno@educacion.navarra.es", "Imagenes/AritzP.jpg");
            win2.Show();
        }
    }
}
