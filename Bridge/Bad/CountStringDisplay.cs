using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Bad
{
    internal class CountStringDisplay: CountDisplay
    {
        private string _str;

        private int _width;

        public CountStringDisplay(string str, int width)
        {
            _str = str;
            _width = width;
        }
        public override void Open()
        {

        }

        public override void Print()
        {

        }

        public override void Close()
        {

        }

        public override void DoDisplay()
        {

        }

        public override void MultiDisplay()
        {

        }
    }
}
