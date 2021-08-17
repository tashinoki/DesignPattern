using System;

public class UnderlinePen: IProduct
{
    private char _decochar;

    public UnderlinePen(char decochar)
    {
        _decochar = decochar;
    }

    public void Use(string str)
    {
        Console.WriteLine("");
        var length = str.Length;

        for (int i = 0; i < length; i++)
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