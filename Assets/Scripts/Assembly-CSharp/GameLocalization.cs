using System;
using System.Collections.Generic;
using UnityEngine;

public class GameLocalization : MonoBehaviour
{
	public static Action<SystemLanguage> LanguageChangeAc;

	public static Action LanguageUpdateAc;

	public static bool Inited;

	private static Dictionary<string, string> m_OldDictionary;

	public static SystemLanguage CurLanguage;

	public static int LanguageSelectedByUser
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private static bool LoadDictionary(string pValue)
	{
		return false;
	}

	public static string Get(string key)
	{
		return null;
	}

	public static void InitLanguage()
	{
	}

	public static void ForceSetLanguage(SystemLanguage pLang, bool pIsSelect = false)
	{
	}

	public static string GetFileName(SystemLanguage pLang)
	{
		return null;
	}
}
