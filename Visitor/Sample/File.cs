namespace DesignPattern.Visitor.Sample
{
    public class File: Entry
    {
        private string _name;
        private int _size;

        public File(string name, int size)
        {
            _name = name;
            _size = size;
        }

        public override string GetName() => _name;

        public override int GetSize() => _size;

        public override void Accept(Visitor visitor) => visitor.Visit(this);
    }
}