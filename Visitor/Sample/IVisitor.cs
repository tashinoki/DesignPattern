namespace DesignPattern.Visitor.Sample
{
    public interface Visitor
    {
      void Visit(File file);

      void Visit(Directory directory);
    }
}