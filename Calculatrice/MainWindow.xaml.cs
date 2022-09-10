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

namespace Calculatrice
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float number1 = 0;
        float number2 = 0;
        string operation = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 0;
                textBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 0;
                textBox.Text = number2.ToString();
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                textBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                textBox.Text = number2.ToString();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                textBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                textBox.Text = number2.ToString();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                textBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                textBox.Text = number2.ToString();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                textBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                textBox.Text = number2.ToString();
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                textBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                textBox.Text = number2.ToString();
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                textBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                textBox.Text = number2.ToString();
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                textBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                textBox.Text = number2.ToString();
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                textBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                textBox.Text = number2.ToString();
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                textBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                textBox.Text = number2.ToString();
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bt_plus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            textBox.Text = "0";
        }

        private void bt_moins_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            textBox.Text= "0";
        }

        private void bt_mul_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            textBox.Text = "0";
        }

        private void bt_div_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            textBox.Text = "0";
        }

        private void bt_equal_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox.Text = (number1 + number2).ToString();
                    number1 = number1 + number2;
                    number2 = 0;
                    break;
                case "-":
                    textBox.Text = (number1 - number2).ToString();
                    number1 = number1 - number2;
                    number2 = 0;
                    break;
                case "*":
                    textBox.Text = (number1 * number2).ToString();
                    number1 = number1 * number2;
                    number2 = 0;
                    break;
                case "/":
                    if (number2 == 0)
                    {
                        textBox.Text = "Error";
                    }
                    else
                    {
                        textBox.Text = (number1 / number2).ToString();
                        number1 = number1 / number2;
                        number2 = 0;
                    }
                    break;

            }
                
        }

        private void bt_ce_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            textBox.Text = "0";

        }
    }
}
