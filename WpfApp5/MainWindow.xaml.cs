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

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();//
        }

        private void sprawdz_Click(object sender, RoutedEventArgs e)
        {
            if (paczka.IsChecked == true)
            {
                cena.Text = "Cena: 10zl";
            }
            else if (list.IsChecked == true)
            {
                cena.Text = "Cena: 1,5zl";
            }
            else if (pocztowka.IsChecked == true)
            {
                cena.Text = "Cena: 1zl"; 
            }
        }
    }
}
