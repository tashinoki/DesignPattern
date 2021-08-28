using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Command.Sample
{
    public class DrawCommnad: ICommand
    {
        private IDrawable _drawable;

        private Point _position;

        public void Execute(IDrawable drawable, Point position)
        {
            _drawable = drawable;
            _position = position;
        }

        public void Execute()
        {
            _drawable.Draw(_position.X, _position.Y);
        }
    }
}
