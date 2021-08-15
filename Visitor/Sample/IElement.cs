namespace DesignPattern.Visitor.Sample
{
    public interface IElement
    {
    	void Accept(Visitor visitor);
    }
}