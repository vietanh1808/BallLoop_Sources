using System.Collections.Generic;
using EasyGame.Ads;
using UnityEngine;
using Voodoo.Sauce.Core;

public class VoodooSauceAdapter : MonoBehaviour, IEasyRv, IEasyInterstitial, IEasyBanner
{
	public enum GameEndReason
	{
		other = 0,
		win = 1,
		lost = 2,
		exit = 3,
		retry = 4
	}

	public enum CurrencyUsed
	{
		coins = 0,
		life = 1,
		booster_select = 2,
		booster_clear = 3,
		booster_move = 4,
		iap = 5,
		rv = 6,
		booster = 7
	}

	public static bool Inited;

	private const string m_Sdk = "VoodooSdk";

	private const string m_LogTag = "VdSdkAdapter -> ";

	public string CurLevelFunnel;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnInitFinishEvent(VoodooSauceInitCallbackResult pResult)
	{
	}

	private void OnGameLevelProgressEvent(LevelStateReport pReport)
	{
	}

	public void SendEventArray(string pSdk, string pStr)
	{
	}

	public void SendEventDic(string pSdk, string pName, Dictionary<string, object> pDic)
	{
	}

	private void OnAssetReportEvent(string pSdk, AssetChangeReport pData)
	{
	}

	public bool IsRvReady()
	{
		return false;
	}

	private void OnRvAdsActionEvent(EasyAdsAction pAction)
	{
	}

	public bool IsInterstitialReady()
	{
		return false;
	}

	private void OnInterstitialAdsActionEvent(EasyAdsAction pAction)
	{
	}

	private void OnBannerAdsActionEvent(EasyAdsAction pAction)
	{
	}
}
