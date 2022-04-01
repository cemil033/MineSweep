using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweep
{
    public class Cell : ICell
    {
        private bool _open = false;
        private bool _isMarked = false;
        private bool _isMine;
        private bool _isWrongCell = false;

        public bool IsOpen
        {
            get => _open;
            set
            {
                _open = value;
                if (IsMarked) IsMarked = false;
                InvokePropertyChanged(nameof(IsOpen));
            }
        }
        public bool IsMarked
        {
            get => _isMarked;
            set
            {
                _isMarked = value;
                InvokePropertyChanged(nameof(IsMarked));
            }
        }
        public bool IsMine
        {
            get => _isMine;
            set
            {
                _isMine = value;
                NeighborMines = 255;
            }
        }
        public bool IsWrongCell
        {
            get => _isWrongCell;
            internal set
            {
                _isWrongCell = value;
                InvokePropertyChanged(nameof(IsWrongCell));
            }
        }

        public byte NeighborMines { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;       

        private void InvokePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
