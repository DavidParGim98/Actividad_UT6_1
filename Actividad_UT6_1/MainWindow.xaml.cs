using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

namespace Actividad_UT6_1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Usuario> conversacion = new ObservableCollection<Usuario>();

        public MainWindow()
        {
            InitializeComponent();

            Chat.DataContext = conversacion;
        }

        private void Nueva_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            conversacion = new ObservableCollection<Usuario>();
        }

        private void Nueva_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (Chat!=null)
            {
                e.CanExecute = true;
            }
            else 
            {
                e.CanExecute = false;
            }

        }

        private void Guardar_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                //Falta implemetar
            }
        }

        private void Guardar_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (Chat != null)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }

        }

        private void Salir_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }

        private void Salir_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Configuracion_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //No implementado
        }

        private void Configuracion_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Conexion_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Conexión correcta con el servidor del Bot", "Comprobar Conexión", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Conexion_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Enviar_Click(object sender, RoutedEventArgs e)
        {
            if (ChatBox.Text.Length > 0)
            {
                conversacion.Add(new Usuario("assets/hombre.png", ChatBox.Text));
                conversacion.Add(new Usuario("assets/robot.png", "No tengo ganas de hablar ahora"));

                ChatBox.Text = "";
            }
            
        }
    }
}
