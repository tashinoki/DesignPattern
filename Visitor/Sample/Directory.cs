using System.Collections;

namespace DesignPattern.Visitor.Sample
{
public class Directory: Entry
{

	private string _name;
	private ArrayList _dir = new ArrayList();

	public override string GetName() => _name;

	public Directory(string name)
	{
		_name = name;
	}

	public override int GetSize()
	{
		int size = 0;
		IEnumerator it = _dir.GetEnumerator();
		while (it.MoveNext())
		{
			Entry entry = it.Current as Entry;
			if (entry is null)
				continue;
				
			size += entry.GetSize();
		}
		return size;
	}

	public new Entry Add(Entry entry)
	{
		_dir.Add(entry);
		return this;
	}

	public IEnumerator GetEnumerator()=> _dir.GetEnumerator();

	public override void Accept(Visitor v) => v.Visit(this);
}
}