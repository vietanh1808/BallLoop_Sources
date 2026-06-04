public class CsvGldBase
{
	public string[][] All;

	public string FilePath;

	public void Init(string pPath = "", string pContent = "")
	{
	}

	public string Cell(int pRow, int pCol)
	{
		return null;
	}

	public int GetStartIndex(string pKey, int pCol = 0)
	{
		return 0;
	}

	public int GetEndIndex(int pStartIndex, int pCol = 0)
	{
		return 0;
	}

	public int GetStartColumn(string pKey, int pRow = 0)
	{
		return 0;
	}
}
