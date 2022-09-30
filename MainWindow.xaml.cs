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

namespace Tema2_CalculadoraBasica
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

        private void calcularButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (boxOperador.Text)
                {
                    case "+":
                        boxResultado.Text = (int.Parse(boxOperador1.Text) + int.Parse(boxOperador2.Text)).ToString();
                        break;
                    case "-":
                        boxResultado.Text = (int.Parse(boxOperador1.Text) - int.Parse(boxOperador2.Text)).ToString();
                        break;
                    case "*":
                        boxResultado.Text = (int.Parse(boxOperador1.Text) * int.Parse(boxOperador2.Text)).ToString();
                        break;
                    case "/":
                        boxResultado.Text = (int.Parse(boxOperador1.Text) / int.Parse(boxOperador2.Text)).ToString();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha introducido mal los operadores. " + ex.Message, Title, MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
        }

        private void limpiarButton_Click(object sender, RoutedEventArgs e)
        {
            boxOperador1.Text = "";
            boxOperador2.Text = "";
            boxOperador.Text = "";
            boxResultado.Text = "";
        }

        private void boxOperador_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (boxOperador.Text == "+" || boxOperador.Text == "-" || boxOperador.Text == "*" || boxOperador.Text == "/")
            {
                calcularButton.IsEnabled = true;
            }
            else
            {
                calcularButton.IsEnabled = false;
            }
        }
    }
}
