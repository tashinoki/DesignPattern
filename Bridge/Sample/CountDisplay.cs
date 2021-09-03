using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Sample
{
    internal class CountDisplay : Display
    {
        private IDisplayImp _displayImp;

        public CountDisplay(IDisplayImp displayImp)
        {
            _displayImp = displayImp;
        }

        public void MultiDisplay(int times)
        {
            Open();

            for(var i = 0; i < times; i++)
            {
                Print();
            }

            Close();
        }
    }
}
