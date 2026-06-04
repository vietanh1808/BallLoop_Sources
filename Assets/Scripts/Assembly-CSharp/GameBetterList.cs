using System.Diagnostics;

public class GameBetterList<T>
{
	public int size;

	public T[] buffer;

	[DebuggerHidden]
	public T this[int i]
	{
		get
		{
			return default(T);
		}
		set
		{
		}
	}

	public void Clear()
	{
	}

	public void Add(T item)
	{
	}

	private void AllocateMore()
	{
	}
}
