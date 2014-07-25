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

namespace LoginIndicator.Serv
{
    /// <summary>
    /// Interaction logic for Serv_Lino1.xaml
    /// </summary>
    public partial class Serv_Lino1 : UserControl
    {
        public Serv_Lino1()
        {
            InitializeComponent();
            if (ServerStat.ShowStat("106.187.95.13") == "稼動中")
            {
                Lino1_STAT.Foreground = Brushes.LightGreen;
                Lino1_STAT.Content = "稼動中";
                Lino1_LAT.Content = ServerStat.ShowLat("106.187.95.13");
            }
            else
            {
                Lino1_STAT.Foreground = Brushes.Red;
                Lino1_STAT.Content = "停止中";             
                Lino1_LAT.Content = "N/A";
            }
           
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (ServerStat.ShowStat("106.187.95.13") == "稼動中")
            {
                Lino1_STAT.Foreground = Brushes.LightGreen;
                Lino1_STAT.Content = "稼動中";
                Lino1_LAT.Content = ServerStat.ShowLat("106.187.95.13");
            }
            else
            {
                Lino1_STAT.Foreground = Brushes.Red;
                Lino1_STAT.Content = "停止中";
                Lino1_LAT.Content = "N/A";
            }
        }
    }
}
