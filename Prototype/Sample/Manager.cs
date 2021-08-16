using System;
using System.Collections.Generic;

internal class Manager
{
    private Dictionary<string, IProduct> _showcase = new Dictionary<string, IProduct>();

    public void Register(string name, IProduct prod)
    {
        _showcase.Add(name, prod);
    }

    public IProduct Create(string name)
    {
        if (_showcase.TryGetValue(name, out var product))
        {
            return product.CreateClone();
        }

        throw new Exception("");
    }
}