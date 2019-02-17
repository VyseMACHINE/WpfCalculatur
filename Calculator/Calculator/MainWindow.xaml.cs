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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string expression;
        private long first;
        private long second;
        private int act;
        private int actNext;
        private int plus, minus, multi, devide;

        public MainWindow()
        {
            InitializeComponent();
            expression = "";
            first = 0;
            second = 0;
            act = 0;
            actNext = 0;
            plus = 1;
            minus = 2;
            multi = 3;
            devide = 4;
        }

        private void FirstButtonClick(object sender, RoutedEventArgs e)
        {
            expression += "1";
            whatTextBlock.Text += "1";
        }

        private void SecondButtonClick(object sender, RoutedEventArgs e)
        {
            expression += "2";
            whatTextBlock.Text += "2";
        }

        private void ThirdButtonClick(object sender, RoutedEventArgs e)
        {
            expression += "3";
            whatTextBlock.Text += "3";
        }

        private void FourthButtonClick(object sender, RoutedEventArgs e)
        {
            expression += "4";
            whatTextBlock.Text += "4";
        }

        private void FivthButtonClick(object sender, RoutedEventArgs e)
        {
            expression += "5";
            whatTextBlock.Text += "5";
        }

        private void SixthButtonClick(object sender, RoutedEventArgs e)
        {
            expression += "6";
            whatTextBlock.Text += "6";
        }

        private void SeventhButtonClick(object sender, RoutedEventArgs e)
        {
            expression += "7";
            whatTextBlock.Text += "7";
        }

        private void EightButtonClick(object sender, RoutedEventArgs e)
        {
            expression += "8";
            whatTextBlock.Text += "8";
        }

        private void NinethButtonClick(object sender, RoutedEventArgs e)
        {
            expression += "9";
            whatTextBlock.Text += "9";
        }

        private void ZeroButtonClick(object sender, RoutedEventArgs e)
        {
            if (expression != "")
            {
                expression += "0";
                whatTextBlock.Text += "0";
            }
        }

        private void PlusButtonClick(object sender, RoutedEventArgs e)
        {
            if (actNext != plus && expression != "")
            {
                if (act != 0)
                    actNext = plus;
                else
                    act = plus;

                if (first != 0)
                {
                    second = long.Parse(expression);
                    expression = "";
                }
                else
                {
                    first = long.Parse(expression);
                    expression = "";
                }
                if (first != 0 && second != 0)
                {
                    Result();
                }
                whatTextBlock.Text += " + ";
            }
        }

        private void MinusButtonClick(object sender, RoutedEventArgs e)
        {
            if (actNext != minus && expression != "")
            {
                if (act != 0)
                    actNext = minus;
                else
                    act = minus;

                if (first != 0)
                {
                    second = long.Parse(expression);
                    expression = "";
                }
                else
                {
                    first = long.Parse(expression);
                    expression = "";
                }
                if (first != 0 && second != 0)
                {
                    Result();
                }
                whatTextBlock.Text += " - ";
            }
        }

        private void MultiplyButtonClick(object sender, RoutedEventArgs e)
        {
            if (actNext != multi && expression != "")
            {
                if (act != 0)
                    actNext = multi;
                else
                    act = multi;

                if (first != 0)
                {
                    second = long.Parse(expression);
                    expression = "";
                }
                else
                {
                    first = long.Parse(expression);
                    expression = "";
                }
                if (first != 0 && second != 0)
                {
                    Result();
                }
                whatTextBlock.Text += " * ";
            }
        }

        private void DevideButtonClick(object sender, RoutedEventArgs e)
        {
            if (actNext != devide && expression !="")
            {
                if (act != 0)
                    actNext = devide;
                else
                    act = devide;

                if (first != 0)
                {
                    second = long.Parse(expression);
                    expression = "";
                }
                else
                {
                    first = long.Parse(expression);
                    expression = "";
                }
                if (first != 0 && second != 0)
                {
                    Result();
                }
                whatTextBlock.Text += " / ";
            }
        }

        private void ResultButtonClick(object sender, RoutedEventArgs e)
        {
            if (act != 0)
            {
                actNext = 0;
                Result();
                expression = "";
                first = 0;
                second = 0;
                act = 0;
            }
        }

        private void Result()
        {
            if (actNext == 0)
            {
                second = long.Parse(expression);
                expression = "";
            }

            if (act == plus)
            {
                first = first + second;
            }
            else if (act == minus)
            {
                first = first - second;
            }
            else if (act == multi)
            {
                first = first * second;
            }
            else if (act == devide)
            {
                first = first / second;
            }
            act = actNext;
            answerTextBlock.Text = first.ToString();
            whatTextBlock.Text = "";

        }
    }
}
