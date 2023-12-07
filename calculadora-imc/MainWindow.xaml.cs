using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace calculadora_imc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float altura = float.Parse(caixaDeTextoAltura.Text);
            float peso = float.Parse(caixaDeTextoPeso.Text);
            double imc = peso/ (altura * altura);
            //string imcString = imc.ToString();

            if (imc < 18.5)
            {
                caixaDeTextoImc.Text = $"Seu imc é: {Math.Round(imc,2)} Abaixo do Peso";
            }
            else if (imc > 18.5 && imc < 24.9)
            {
                caixaDeTextoImc.Text = $"Seu imc é: {Math.Round(imc, 2)} Peso Ideal";
            }
            else if (imc >= 25 && imc < 29.9)
            {
                caixaDeTextoImc.Text = $"Seu imc é: {Math.Round(imc, 2)} Sobrepeso";
            }
            else if (imc >= 30 && imc < 30.9)
            {
                caixaDeTextoImc.Text = $"Seu imc é: {Math.Round(imc, 2)} Obesidade";
            }
            else 
            {
                caixaDeTextoImc.Text = $"Seu imc é: {Math.Round(imc, 2)} Obesidade Grave";
            }
        }
    }
}