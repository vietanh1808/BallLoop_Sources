using System;
using System.Collections.Generic;
using UnityEngine;

public class GameLocalizeConfig : ScriptableObject
{
	[Serializable]
	public class LanguageInfo
	{
		public bool Active;

		public List<SystemLanguage> SysLangs;

		public string FileName;
	}

	private static GameLocalizeConfig m_Instance;

	[Header("未配置时的默认语言")]
	public LanguageInfo LangDefault;

	[Header("配置语言及对应文件")]
	public List<LanguageInfo> LangList;

	public static GameLocalizeConfig Instance => null;

	public void InitForRunning()
	{
	}
}
