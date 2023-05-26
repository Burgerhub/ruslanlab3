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
using System.Windows.Shapes;

namespace ruslanprackt3var10
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double A = double.Parse(vod1.Text);
            double B = double.Parse(vod2.Text);
            double C = double.Parse(vod3.Text);

            if (A < B && B < C)
            {
                A *= 2;
                B *= 2;
                C *= 2;
            }
            else
            {
                A = -A;
                B = -B;
                C = -C;
            }

            otv.Text = $"A={A} B={B} C={C}";

        }
    }
}
