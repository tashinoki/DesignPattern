using System;
using System.Collections;

namespace DesignPattern.Visitor.Sample
{
    public class ListVisitor: Visitor
    {
      private string _currentdir = "";

      public override void Visit(File file)
      {
        Console.WriteLine(_currentdir + "/" + file.GetName());
      }

      public override void Visit (Directory directory)
      {
        Console.WriteLine(_currentdir + "/" + directory.GetName());
        string savedir = _currentdir;
        _currentdir = _currentdir + "/" + directory.GetName();
        IEnumerator it = directory.GetEnumerator();

        while (it.MoveNext())
        {
            Entry entry = (Entry)it.Current;
            entry.Accept(this);
        }
        _currentdir = savedir;
      }
    }
}