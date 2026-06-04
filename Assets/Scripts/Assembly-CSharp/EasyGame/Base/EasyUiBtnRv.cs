using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EasyGame.Base
{
	public class EasyUiBtnRv : EasyUiBtn
	{
		public string RvKey;

		public Action<bool> OnRewardAc;

		public Action<bool> OnRvClickAc;

		public string AnalysisKey;

		public string AnalysisKeyCN;

		public string AnalysisType;

		public int BtnRvState;

		public bool ClickFailedTip;

		public bool ShowFailedTip;

		[Header("消耗资源-比如广告券")]
		public string CostAssetKey;

		public int CostAssetNum;

		public Image RvIcon;

		public GameObject RvTicketRoot;

		public TextMeshProUGUI RvTicketText;

		private bool IsNoRvAds => false;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetVisible(bool pVisible, int pType = 0)
		{
		}

		private void OnAssetChangeEvent(string pAsset, float pValue)
		{
		}

		public override void OnBtnClickEvent()
		{
		}

		private void OnRvResultEvent(EasyAdsState pState, bool pReal)
		{
		}

		private void ProcessShowRv(int pSkipState)
		{
		}
	}
}
