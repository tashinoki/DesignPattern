using System;

public class MessageBox: IProduct
{
    private char _decochar;
    
    public MessageBox(char decochar)
    {
        _decochar = decochar;
    }

    public void Use(string str)
    {
        var length = str.Length;

        for (int i = 0; i < length + 4; i++)
        {
            Console.Write(_decochar);
        }
        Console.WriteLine("");

        Console.WriteLine($"{_decochar} {str} {_decochar}");

        for (var i = 0; i < length + 4; i++)
        {
            Console.Write(_decochar);
        }
        Console.WriteLine("");
    }

    public IProduct CreateClone()
    {
        return Clone() as IProduct;
    }

    public object Clone()
    {
        return this.MemberwiseClone();
    }
}