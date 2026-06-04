using System;
using System.Collections.Generic;

public class GameData
{
	public const int WinCycle = 6;

	public static int SkinIndex;

	public static bool RankUnlock;

	public static Dictionary<string, AssetGld> AssetDic;

	public static Dictionary<int, LevelGld> LevelDic;

	public static List<int> LevelCycle;

	public static Dictionary<string, int[]> LevelSpLockDic;

	public static int FirstHardLevel;

	public static List<WinStreakReward> WStreaks;

	private static Dictionary<ColorType, ColorData> m_Colors;

	public static Dictionary<string, ShopGld> ShopDic;

	public static bool GameIsStart;

	internal static string CurRvId;

	internal static string CurRvPlace;

	public static string CurInterstitialPlace;

	private const string InstallTimeTimeKey = "InstallTimeKey";

	public static bool ShowPlayUi
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static int PurchaseNum
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int ShopOpenNum
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int MaxSteakNum
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int CurSteakNum
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int LastSceneId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static Dictionary<ColorType, ColorData> ColorDic => null;

	public static int CurLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int UnlockLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static bool gameIsStart { get; set; }

	public static int SessionNum
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int TotalTime
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int PlayedTime { get; set; }

	public static string VersionCode
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static bool EnableHaptic
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool EnableBgMusic
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool EnableEffectMusic
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static DateTime InstallTime => default(DateTime);

	public static int WatchedRvCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static DateTime NowTime => default(DateTime);

	public static DateTime Today => default(DateTime);

	public static int TimeOffset
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int GetToolLockState(string pTool)
	{
		return 0;
	}

	public static void SetToolLockState(string pTool, int pValue)
	{
	}

	public static int GetLevelEnterNum(int pLevel)
	{
		return 0;
	}

	public static void SetLevelEnterNum(int pLevel, int pValue)
	{
	}

	public static int GetLevelRetryNum(int pLevel)
	{
		return 0;
	}

	public static void SetLevelRetryNum(int pLevel, int pValue)
	{
	}

	public static int GetLevelFailNum(int pLevel)
	{
		return 0;
	}

	public static void SetLevelFailNum(int pLevel, int pValue)
	{
	}

	public static int GetLevelUseToolNum(int pLevel)
	{
		return 0;
	}

	public static void SetLevelUseToolNum(int pLevel, int pValue)
	{
	}

	public static int GetLevelRvNum(int pLevel)
	{
		return 0;
	}

	public static void SetLevelRvNum(int pLevel, int pValue)
	{
	}

	public static int GetLevelInvalidStepNum(int pLevel)
	{
		return 0;
	}

	public static void SetLevelInvalidStepNum(int pLevel, int pValue)
	{
	}

	public static void InitGame()
	{
	}

	public static void InitAssets()
	{
	}

	public static void InitLevelGld()
	{
	}

	public static void InitColorGld()
	{
	}

	public static void InitStoreGld()
	{
	}

	public static Dictionary<string, float> StrToDicStrFloat(string pStr)
	{
		return null;
	}

	public static void InitCommonData()
	{
	}
}
