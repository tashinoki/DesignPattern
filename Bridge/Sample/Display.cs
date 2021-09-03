using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Sample
{
    internal class Display
    {
        private IDisplayImp _displayImp;

        public Display(IDisplayImp displayImp)
        {
            _displayImp = displayImp;
        }

        public void Open()
        {

        }

        public void Print()
        {

        }

        public void Close()
        {

        }

        public void DoDisplay()
        {
            Open();
            Print();
            Close();
        }
    }
}
