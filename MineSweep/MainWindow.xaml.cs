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

namespace MineSweep
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void RestartEasy(object sender, RoutedEventArgs e)
		{
			Resources["mineSweeperModel"] = new MainWindowViewModel(10, 10, 10);
		}

		private void RestartMedium(object sender, RoutedEventArgs e)
		{
			Resources["mineSweeperModel"] = new MainWindowViewModel(30, 15, 10);
		}

		private void RestartHard(object sender, RoutedEventArgs e)
		{
			Resources["mineSweeperModel"] = new MainWindowViewModel(100, 30, 20);
		}
		private void RestartCustom(object sender, RoutedEventArgs e)
		{
			var set = new SetView();
            if (set.ShowDialog() == true)
            {
				Resources["mineSweeperModel"] = new MainWindowViewModel(int.Parse(set.mines.Text),int.Parse(set.colms.Text) , int.Parse(set.rows.Text));
			}
		}

		private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == System.Windows.Input.Key.Escape) Close();
		}

	}
}
