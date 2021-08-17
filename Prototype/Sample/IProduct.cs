using System;

public interface IProduct: ICloneable
{
    public void Use(string s);

    public IProduct CreateClone();
}