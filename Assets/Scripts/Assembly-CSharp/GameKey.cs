using System;
using System.Collections.Generic;
using UnityEngine;

public class GameKey
{
	public const string LevelKey = "Level";

	public const string CloudData_UserData = "PlayerDatas.data";

	public static string CurRvKeyCN;

	public const string StoreId_RemoveAds = "remove_ads";

	public const string StoreId_Starter_Bundle = "lives_refill_bundle";

	public const string StoreId_No_Ads_Pack = "no_ads_pack";

	public const string StoreId_Small_Bundle = "small_bundle";

	public const string StoreId_Medium_Bundle = "medium_bundle";

	public const string StoreId_Large_Bundle = "large_bundle";

	public const string StoreId_Giant_Bundle = "giant_bundle";

	public const string StoreId_Ultra_Bundle = "ultra_bundle";

	public const string StoreId_Fail_Offer = "fail_offer";

	public const string StoreId_Hard_Fail_Offer = "hard_fail_offer";

	public const string StoreId_Popup1 = "popuppack_001";

	public const string StoreId_Popup2 = "popuppack_002";

	public const string StoreId_Popup3 = "popuppack_003";

	public const string StoreId_Gold1 = "coinpack_001";

	public const string StoreId_Gold2 = "coinpack_002";

	public const string StoreId_Gold3 = "coinpack_003";

	public const string StoreId_Gold4 = "coinpack_004";

	public const string StoreId_Gold5 = "coinpack_005";

	public const string StoreId_Gold6 = "coinpack_006";

	public const string StoreId_NoRv = "remove_rv";

	public const int SlotMax = 8;

	public const int SlotMin = 3;

	public const string Asset_1 = "1";

	public const string Asset_2 = "2";

	public const string Asset_100 = "100";

	public const string Asset_101 = "101";

	public const string Asset_102 = "102";

	public static string[] AssetKeys;

	public const string Cell_Wall = "墙";

	public const string Cell_Empty = "空";

	public const string Cell_Obstacle = "障碍";

	public static LayerMask Layer_Cell;

	public static LayerMask Layer_Pipe;

	public static LayerMask Layer_Break;

	public static LayerMask Layer_Obstacle;

	public static LayerMask Layer_Bead;

	public static LayerMask Layer_Ground;

	public const string LevelDiffNormal = "普通";

	public const string LevelDiffHard = "困难";

	public const string LevelDiffVeryHard = "非常困难";

	public const string LevelDiffMedium = "中等";

	public const string LevelSp_JinZhu = "金猪";

	public const string LevelSp_DuiDieZhuanKuai = "堆叠砖块";

	public const string LevelSp_WenHaoPaoTai = "问号炮台";

	public const string LevelSp_LianJieGan = "连接杆";

	public const string LevelSp_SanJiaoPaoTai = "三角炮台(40-50)";

	public const string LevelSp_SiGeKuai = "四格块";

	public const string LevelSp_LanGan = "栏杆";

	public const string LevelSp_CangKu = "仓库";

	public const string LevelSp_YaoShi = "钥匙";

	public static List<string> MainShowCanvasList;

	public static List<string> LevelShowCanvasList;

	public const string UiLayer_TopBar = "TopBar";

	public const string UiLayer_TopCenter = "TopCenter";

	public const string UiLayer_TopRight = "TopRight";

	public const string UiLayer_TopLeft = "TopLeft";

	public const string UiLayer_BottomCenter = "BottomCenter";

	public const string UiLayer_BottomRight = "BottomRight";

	public const string UiLayer_BottomLeft = "BottomLeft";

	public const string UiLayer_MainBg = "MainBg";

	public const string UiLayer_StartBtn = "MainStart";

	public const string UiLayer_Exp = "Exp";

	public const string UiLayer_Gold = "Gold";

	public const string UiLayer_Power = "Power";

	public const string UiLayer_LevelTips = "LevelTips";

	public static Dictionary<SpecialBtnId, GameSpecialBtnView> SpBtnDic;

	public static Dictionary<SpecialBtnId, float> SpeBtnFactor;

	private static Dictionary<SpecialBtnId, GameObject> SpeBtnExtraModel;

	public static float SpeedBarTime;

	public static float ReduceTime;

	public static bool AutoPopLvUp;

	private static Dictionary<string, List<ExpLvGld>> ExpLvDic;

	public static Dictionary<string, int> PowerMaxDic;

	public const string Key_CanvasAll = "GameUiCanvasAll";

	public const int UiLayerTop = 9999;

	public const int UiLayerBottom = -9999;

	private static readonly string[] EnNumArray;

	private static readonly string[] CnNumArray;

	private static readonly string[] CHTNumArray;

	public static string[] NumUnit => null;

	public static Dictionary<string, float> StrToDicStrFloat(string pStr, char pSplite1 = ',', char pSplite2 = '_')
	{
		return null;
	}

	public static List<int[]> StrToDicIntInt(string pStr, char pSplite1 = ',', char pSplite2 = '_')
	{
		return null;
	}

	public static List<string> StrToStrList(string pStr, char pSplit = ',')
	{
		return null;
	}

	public static List<int> StrToIntList(string pStr, char pSplit = ',')
	{
		return null;
	}

	public static List<float> StrToFloatList(string pStr, char pSplit = ';')
	{
		return null;
	}

	public static GameObject CreateMod(GameObject pPreafab, Transform pParent)
	{
		return null;
	}

	public static void DestroyMod(GameObject pMod)
	{
	}

	public static void DestroyAllChild(Transform pTrans)
	{
	}

	public static void CheckSpRepeat(Transform pRoot, SpType pType, bool pClearAll = false)
	{
	}

	public static string GetSpName(SpType pType)
	{
		return null;
	}

	public static List<Vector2Int> StrToCellPos(string tStr)
	{
		return null;
	}

	public static List<string> StrToColors(string tStr)
	{
		return null;
	}

	public static bool IsInAreaXZ(Vector3 pCenter, Vector3 pPos, float pSize)
	{
		return false;
	}

	public static string GetSpIcon(string pSp, bool pLock = false)
	{
		return null;
	}

	public static SpType GetSpType(string pSp)
	{
		return default(SpType);
	}

	public static int GetLevelSpIndex(string pSpName)
	{
		return 0;
	}

	public static int GetDifficultSp(string pStr)
	{
		return 0;
	}

	public static int GetDifficultMat(string pStr)
	{
		return 0;
	}

	public static int GetTooIndex(string pToolAsset)
	{
		return 0;
	}

	public static string GetAssetStr(string pAssetId)
	{
		return null;
	}

	public static void SetSpeBtnStatus(SpecialBtnId pSpeBtnId, bool pEnable)
	{
	}

	public static DateTime GetSpeBtnBuffTime(SpecialBtnId pId)
	{
		return default(DateTime);
	}

	public static void SetSpeBtnBuffTime(SpecialBtnId pId, DateTime pTime)
	{
	}

	public static DateTime GetSpeBtnDailyTime(SpecialBtnId pId)
	{
		return default(DateTime);
	}

	public static void SetSpeBtnDailyTime(SpecialBtnId pId, DateTime pTime)
	{
	}

	public static int GetSpeBtnDailyMax(SpecialBtnId pId)
	{
		return 0;
	}

	public static int GetSpeBtnDailyNum(SpecialBtnId pId)
	{
		return 0;
	}

	public static void SetSpeBtnDailyNum(SpecialBtnId pId, int pNum)
	{
	}

	public static int GetSpeBtnMaxDailyNum(SpecialBtnId pId)
	{
		return 0;
	}

	public static int GetSpeBtnWorkedSum(SpecialBtnId pId)
	{
		return 0;
	}

	public static void SetSpeBtnWorkedSum(SpecialBtnId pId, int pNum)
	{
	}

	public static string GetTimeStr(TimeSpan tSpan, int pFormat = 1)
	{
		return null;
	}

	public static int GetExpLv(string pKey)
	{
		return 0;
	}

	public static void SetExpLv(string pKey, int pValue)
	{
	}

	public static int GetExp(string pKey)
	{
		return 0;
	}

	public static void SetExp(string pKey, int pValue)
	{
	}

	public static void AddExp(string pKey, int pValue)
	{
	}

	public static void UpdateExpBar(string pKey, int pValue, float pDelay = 0f)
	{
	}

	public static List<int> GetExpLvUpList(string pKey)
	{
		return null;
	}

	public static void SetExpLvUpList(string pKey, List<int> pList)
	{
	}

	public static List<ExpLvGld> GetExpLvGld(string pKey)
	{
		return null;
	}

	public static void SetExpLvGld(string pKey, List<ExpLvGld> pList)
	{
	}

	public static void AddPower(string pKey, int pValue)
	{
	}

	public static void UpdatePowerBar(string pPower, int pValue, float pDelay = 0f)
	{
	}

	public static int GetPower(string pKey)
	{
		return 0;
	}

	public static void SetPower(string pKey, int pValue)
	{
	}

	public static int PowerMax(string pKey)
	{
		return 0;
	}

	public static DateTime GetPowerDateTime(string pKey)
	{
		return default(DateTime);
	}

	public static void SetPowerDateTime(string pKey, DateTime pTime)
	{
	}

	public static void AddAsset(string pAsset, float pValue, bool pInEarnOrCost = true)
	{
	}

	public static void UpdateAssetBar(string pAsset, float pValue, float pDelay = 0f)
	{
	}

	public static string GetAssetCostKey(string pAsset, int pPostFix = 0)
	{
		return null;
	}

	public static string GetAssetEarnKey(string pAsset, int pPostFix = 0)
	{
		return null;
	}

	public static string GetAssetKey(string pAsset, int pPostFix = 0)
	{
		return null;
	}

	public static float GetAsset(string pAsset, int pPostFix = 0)
	{
		return 0f;
	}

	public static void SetAsset(string pAsset, float pAmount, int pPostFix = 0)
	{
	}

	public static string GetStringStr(float pNum)
	{
		return null;
	}

	public static string GetEnStringStr(string pNum, int pFirst = 3, int pLast = 2, int pMax = 5)
	{
		return null;
	}
}
