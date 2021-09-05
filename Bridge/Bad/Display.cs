using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Bad
{
    internal abstract class Display
    {
        public abstract void Open();

        public abstract void Print();

        public abstract void Close();

        public abstract void DoDisplay();
    }
}
