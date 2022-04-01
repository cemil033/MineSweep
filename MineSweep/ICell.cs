using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweep
{
    public interface ICell : INotifyPropertyChanged
    {
        bool IsMarked { get; set; }
        bool IsMine { get; }
        byte NeighborMines { get; }
        bool IsOpen { get; set; }
    }
}
