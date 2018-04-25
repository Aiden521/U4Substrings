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

namespace U4Substring
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // 0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17
            // J o l l e y - R u h n  ,     A  i  d  e  n
            string name = "Jolley-Ruhn, Aiden";
            int startofFirstname = name.IndexOf(",");
            string firstName = name.Substring(startofFirstname + 2, name.Length - startofFirstname - 2);
            MessageBox.Show(firstName);
            string lastName = name.Substring(0, startofFirstname);
            MessageBox.Show(lastName);
        }

    }
}
