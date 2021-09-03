using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Sample
{
    internal class StringDisplayImp: IDisplayImp
    {
        private string _str;

        private int _width;

        public StringDisplayImp(string str, int width)
        {
            _str = str;
            _width = width;
        }

        public void RawOpen()
        {
            Console.WriteLine();
        }

        public void RawPrint()
        {
            Console.WriteLine($"|{_str}|");
        }

        public void RawClose()
        {
            Console.WriteLine();
        }

        private void PrintLine()
        {
            Console.Write("*");

            for(var i = 0; i < _width; i ++)
            {
                Console.Write("-");
            }

            Console.Write("*");
        }
    }
}
