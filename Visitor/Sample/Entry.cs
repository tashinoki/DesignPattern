using System;

namespace DesignPattern.Visitor.Sample
{
    public abstract class Entry: IElement
    {
      public abstract string GetName();
      public abstract int GetSize();

      public Entry Add(Entry entry)
      {
          throw new Exception();
      }

      public abstract void Accept(Visitor visitor);
    }
}