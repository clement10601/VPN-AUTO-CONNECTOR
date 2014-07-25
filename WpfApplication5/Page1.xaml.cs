using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FirstFloor.ModernUI;
using FirstFloor.ModernUI.Windows.Controls;

namespace LoginIndicator
{
    /// <summary>
    /// Page1.xaml 的互動邏輯
    /// </summary>

    public partial class Page1
    {
        private string accessA;
        private string accessB;
        public static Boolean InOrNot = false;

        public Page1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            accessA = AccountA.Text;
            accessB = PasswdB.Password;
            string Access = MySQLconntetor.SQLconnect(accessA, accessB);
            if (Access == "Fail")
            {
                InOrNot = false;
                NavigationCommands.GoToPage.Execute("/Page2.xaml", this);
            }
            else if (Access == "Success")
            {
                InOrNot = true;
                NavigationCommands.GoToPage.Execute("/Dashboard.xaml", this);
            }
            else
            {
                InOrNot = false;
                NavigationCommands.GoToPage.Execute("/Page2.xaml", this);
            }

        }

        private void AccountA_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


    }
}
