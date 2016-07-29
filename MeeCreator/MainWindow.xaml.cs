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

        private void bMouthOval_Click(object sender, RoutedEventArgs e)
        {
            eMouth.Visibility = System.Windows.Visibility.Visible;
            rMouth.Visibility = System.Windows.Visibility.Hidden;
        }

        private void bMouthRectangle_Click(object sender, RoutedEventArgs e)
        {
            rMouth.Visibility = System.Windows.Visibility.Visible;
            eMouth.Visibility = System.Windows.Visibility.Hidden;
        }

        private void bFaceOval_Click(object sender, RoutedEventArgs e)
        {
            eHead.Visibility = System.Windows.Visibility.Visible;
            rHead.Visibility = System.Windows.Visibility.Hidden;
        }

        private void bFaceRectangle_Click(object sender, RoutedEventArgs e)
        {
            rHead.Visibility = System.Windows.Visibility.Visible;
            eHead.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
