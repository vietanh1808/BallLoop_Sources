using System.Collections.Generic;
using UnityEngine;

public class GameByteReader
{
	private byte[] mBuffer;

	private int mOffset;

	private static GameBetterList<string> mTemp;

	public bool canRead => false;

	public GameByteReader(byte[] bytes)
	{
	}

	public GameByteReader(TextAsset asset)
	{
	}

	public Dictionary<string, string> ReadDictionary()
	{
		return null;
	}

	private static string ReadLine(byte[] buffer, int start, int count)
	{
		return null;
	}

	public string ReadLine()
	{
		return null;
	}

	public string ReadLine(bool skipEmptyLines)
	{
		return null;
	}

	public GameBetterList<string> ReadCSV()
	{
		return null;
	}
}
