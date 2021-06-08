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

namespace Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Calc1 calc;
        public MainWindow()
        {
            calc = new Calc1();
            InitializeComponent();
        }
        

        private void button_1_Click(object sender, RoutedEventArgs e)
        {
            calc.AddNumber(1);
            display.Text = calc.GetView();
            summary.Text = calc.Getsummary();
        }

        private void button_2_Click(object sender, RoutedEventArgs e)
        {
            calc.AddNumber(2);
            display.Text = calc.GetView();
            summary.Text = calc.Getsummary();
        }

        private void button_3_Click(object sender, RoutedEventArgs e)
        {
            calc.AddNumber(3);
            display.Text = calc.GetView();
            summary.Text = calc.Getsummary();
        }

        private void button_4_Click(object sender, RoutedEventArgs e)
        {
            calc.AddNumber(4);
            display.Text = calc.GetView();
            summary.Text = calc.Getsummary();
        }

        private void button_6_Click(object sender, RoutedEventArgs e)
        {
            calc.AddNumber(6);
            display.Text = calc.GetView();
            summary.Text = calc.Getsummary();
        }

        private void button_5_Click(object sender, RoutedEventArgs e)
        {
            calc.AddNumber(5);
            display.Text = calc.GetView();
            summary.Text = calc.Getsummary();
        }

        private void button_7_Click(object sender, RoutedEventArgs e)
        {
            calc.AddNumber(7);
            display.Text = calc.GetView();
            summary.Text = calc.Getsummary();
        }

        private void button_8_Click(object sender, RoutedEventArgs e)
        {
            calc.AddNumber(8);
            display.Text = calc.GetView();
            summary.Text = calc.Getsummary();
        }

        private void button_9_Click(object sender, RoutedEventArgs e)
        {
            calc.AddNumber(9);
            display.Text = calc.GetView();
            summary.Text = calc.Getsummary();
        }

        private void button_substr_Click(object sender, RoutedEventArgs e)
        {
            calc.doOperation(1);
            display.Text = calc.GetView();
            summary.Text = calc.Getsummary();
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            calc.doOperation(2);
            display.Text = calc.GetView();
            summary.Text = calc.Getsummary();
        }

        private void button_mult_Click(object sender, RoutedEventArgs e)
        {
            calc.doOperation(3);
            display.Text = calc.GetView();
            summary.Text = calc.Getsummary();
        }

        private void button_div_Click(object sender, RoutedEventArgs e)
        {
            calc.doOperation(4);
            display.Text = calc.GetView();
            summary.Text = calc.Getsummary();
        }

        private void button_res_Click(object sender, RoutedEventArgs e)
        {
            if(calc.zeroCheck())
            {
                calc.ClearAll();
                display.Text = "ERROR";

            }else
            {
                calc.doResult();
                display.Text = calc.GetView();
            }
        }

        private void button_dot_Click(object sender, RoutedEventArgs e)
        {
            calc.setDot();
            display.Text = calc.GetView();
            summary.Text = calc.Getsummary();
        }

        private void ClearAll_Click(object sender, RoutedEventArgs e)
        {
            calc.ClearAll();
            display.Text = calc.GetView();
            summary.Text = calc.Getsummary();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            calc.ClearCurrent();
            display.Text = calc.GetView();
            summary.Text = calc.Getsummary();
        }

        private void button_0_Click(object sender, RoutedEventArgs e)
        {
            calc.AddNumber(0);
            display.Text = calc.GetView();
            summary.Text = calc.Getsummary();
        }
    }
}
