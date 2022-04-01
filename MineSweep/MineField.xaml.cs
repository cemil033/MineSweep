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
	public partial class MineField : UserControl
	{
		public MineField()
		{
			InitializeComponent();
		}

		private const int delta = 10;

		private void CellManipulationStarting(object sender, ManipulationStartingEventArgs e)
		{
			e.ManipulationContainer = this;
			e.Handled = true;
		}

		private void CellManipulationDelta(object sender, ManipulationDeltaEventArgs e)
		{
			IfCell(sender, cell =>
			{
				var len = e.CumulativeManipulation.Translation.Length;
				if (len > delta)
				{
					cell.IsMarked = true;
				}
				e.Handled = true;
			});
		}

		private void CellManipulationCompleted(object sender, ManipulationCompletedEventArgs e)
		{
			IfCell(sender, cell =>
			{
				var len = e.TotalManipulation.Translation.Length;
				if (len < delta)
				{
					cell.IsOpen = true;
				}
				e.Handled = true;
			});
		}

		private void CellMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			IfCell(sender, cell => cell.IsOpen = true);
		}

		private void CellMouseRightButtonDown(object sender, MouseButtonEventArgs e)
		{
			IfCell(sender, cell => cell.IsMarked = !cell.IsMarked);
		}

		private static void IfCell(object sender, Action<ICell> action)
		{
			if ((sender as Border)?.DataContext is ICell cell)
			{
				action(cell);
			}
		}
	}
}
