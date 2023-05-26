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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int A = int.Parse(vod1.Text);
            int B = int.Parse(vod2.Text);

            if (A != B)
            {
                if (A > B)
                {
                    B = A;
                }
                else
                {
                    A = B;
                }
            }
            else
            {
                A = 0;
                B = 0;
            }
            otv.Text=$"A={A} \n B={B}";
        }
    }
}
