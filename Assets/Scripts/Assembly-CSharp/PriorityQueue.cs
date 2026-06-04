using System.Collections.Generic;

public class PriorityQueue<T>
{
	private List<KeyValuePair<T, float>> Elements;

	private HashSet<T> ElementSet;

	public int Count => 0;

	public void Enqueue(T pItem, float pPriority)
	{
	}

	public T Dequeue()
	{
		return default(T);
	}

	public bool Contains(T pItem)
	{
		return false;
	}

	private void HeapifyUp(int pIndex)
	{
	}

	private void HeapifyDown(int pIndex)
	{
	}

	private void Swap(int i, int j)
	{
	}
}
