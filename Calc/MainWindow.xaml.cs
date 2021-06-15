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
        

        private void button_digit_Click(object sender, RoutedEventArgs e)
        {
            calc.AddNumber(Convert.ToInt32(((Button)e.OriginalSource).Content.ToString()));
            display.Text = calc.GetView();
            summary.Text = calc.Getsummary();
        }

        private void button_operation_Click(object sender, RoutedEventArgs e)
        {
            calc.doOperation(((Button)e.OriginalSource).Content.ToString());
            display.Text = calc.GetView();
            summary.Text = calc.Getsummary();
        }
        private void button_res_Click(object sender, RoutedEventArgs e)
        {
            if(calc.zeroCheck())
            {
                calc.ClearAll();
                display.Text = "ERROR";
                return;
            }
            calc.doResult();
            if(!calc.validateLeght())
            {
                display.Text = "ERROR";
                calc.ClearAll();
                return;
            }
            display.Text = calc.GetView();
            
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
    }
}
