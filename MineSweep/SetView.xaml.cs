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

namespace MineSweep
{
    /// <summary>
    /// Interaction logic for SetView.xaml
    /// </summary>
    public partial class SetView : Window
    {
        public SetView()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void cnl_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            (sender as TextBox).Text = "";
        }
    }
}
