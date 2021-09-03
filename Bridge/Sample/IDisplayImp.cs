using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Sample
{
    interface IDisplayImp
    {
        public void RawOpen();

        public void RawPrint();

        public void RawClose();
    }
}
