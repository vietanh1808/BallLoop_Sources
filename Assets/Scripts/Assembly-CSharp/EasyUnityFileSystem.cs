using System.Collections.Generic;
using UnityEngine;

public class EasyUnityFileSystem : MonoBehaviour, IEasySave
{
	private class SaveData
	{
		public Dictionary<string, int> IntDic;

		public Dictionary<string, double> DoubleDic;

		public Dictionary<string, string> StringDic;
	}

	private const string DefaultFile = "PlayerDatas.data";

	private const string AllFile = "AllFile";

	[Header("*额外独立的文件名**命名XXX.data**")]
	public string[] ExtraFiles;

	private static List<string> WaitKeys;

	private static Dictionary<string, SaveData> SaveDic;

	public void Init()
	{
	}

	public void ForceInit(string pStr, string pFileName = "")
	{
	}

	private void Update()
	{
	}

	private SaveData ReadFile(string pFileName)
	{
		return null;
	}

	private void WriteFile(string pFileName)
	{
	}

	private void RemoveFile(string pFileName)
	{
	}

	public void ForceSave()
	{
	}

	public string GetJson(string pFileName = "")
	{
		return null;
	}

	public static bool HasKey(string pKey, string pFileName = "")
	{
		return false;
	}

	public void DeleteKey(string pKey, string pFileName = "")
	{
	}

	public void DeleteAll()
	{
	}

	public int GetInt(string pKey, int pDefaultValue = 0, string pFileName = "")
	{
		return 0;
	}

	public float GetFloat(string pKey, float pDefaultValue = 0f, string pFileName = "")
	{
		return 0f;
	}

	public string GetString(string pKey, string pDefaultValue = "", string pFileName = "")
	{
		return null;
	}

	public void SetInt(string pKey, int value, string pFileName = "")
	{
	}

	public void SetFloat(string pKey, float value, string pFileName = "")
	{
	}

	public void SetString(string pKey, string value, string pFileName = "")
	{
	}
}
