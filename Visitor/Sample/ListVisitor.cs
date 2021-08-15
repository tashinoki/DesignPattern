using System;
using System.Collections;

namespace DesignPattern.Visitor.Sample
{
    public class ListVisitor: Visitor
    {
    	private string _currentdir = "";

		public void Visit(File file)
		{
			Console.WriteLine(_currentdir + "/" + file.GetName());
		}

		public void Visit (Directory directory)
		{
			Console.WriteLine(_currentdir + "/" + directory.GetName());
			var savedir = _currentdir;
			_currentdir = _currentdir + "/" + directory.GetName();
			var it = directory.GetEnumerator();

			while (it.MoveNext())
			{
				Entry entry = it.Current as Entry;
				if (entry is null)
					continue;

				entry.Accept(this);
			}
			_currentdir = savedir;
		}
    }
}