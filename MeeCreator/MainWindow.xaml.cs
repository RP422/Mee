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

namespace MeeCreator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bOval_Click(object sender, RoutedEventArgs e)
        {
            rMouth.Visibility = System.Windows.Visibility.Hidden;
            eMouth.Visibility = System.Windows.Visibility.Visible;
        }

        private void bRectangle_Click(object sender, RoutedEventArgs e)
        {
            eMouth.Visibility = System.Windows.Visibility.Hidden;
            rMouth.Visibility = System.Windows.Visibility.Visible;
        }
    }
}
