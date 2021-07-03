using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class DisplayMain
    {
        public void Run()
        {
            var stringDisplay = new StringDisplay("hogehoge");
            stringDisplay.Show();

            var sideBorder = new SideBorder{ Display = stringDisplay };
            sideBorder.Show();

            var fullBorder = new FullBorder{ Display = stringDisplay };
            fullBorder.Show();
        }
    }

    internal abstract class Display
    {
        abstract public int GetColumns();

        abstract public int GetRows();

        abstract public string GetRowText(int row);

        public void Show()
        {
            for(var row = 0; row < GetRows(); row++)
            {
                Console.WriteLine(GetRowText(row));
            }
        }
    }

    internal abstract class Border: Display
    {
        public Display Display { get; set; }
    }

    internal class StringDisplay: Display
    {
        private readonly string _str;

        public StringDisplay(string str) => _str = str;

        public override int GetColumns() => _str.Length;

        public override int GetRows() => 1;

        public override string GetRowText(int row) => row == 0 ? _str : "";
    }

    internal class SideBorder: Border
    {
        public override int GetColumns() => 1 + Display.GetColumns() + 1;

        public override int GetRows() => Display.GetRows();

        public override string GetRowText(int row)
        {
            var text = Display.GetRowText(row);
            return string.IsNullOrEmpty(text) ? "" : $"*{text}*";
        }
    }

    internal class FullBorder: Border
    {
        public override int GetRows() => 1 + Display.GetRows() + 1;

        public override int GetColumns() => 1 + Display.GetColumns() + 1;

        public override string GetRowText(int row)
        {
            if (row == 0)
            {
                return '+' + new string('-', Display.GetColumns()) + '+';
            }
            else if (row == (Display.GetRows() + 1))
            {
                return '+' + new string('-', Display.GetColumns()) + '+';
            }
            else
            {
                return '|' + Display.GetRowText(row - 1) + '|';
            }
        }
    }
}
