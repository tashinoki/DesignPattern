namespace DesignPattern.Visitor.Sample
{
    public interface IElement
    {
      public void Accept(Visitor visitor);
    }
}