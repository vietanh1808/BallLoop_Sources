using TMPro;
using UnityEngine;

namespace EasyGame.Base
{
	public class EasyUiBtnIap : EasyUiBtn
	{
		public string StoreId;

		public bool IsNoAds;

		private StoreConfigData m_Config;

		public GameObject[] LockUis;

		public GameObject[] UnlockUis;

		public TextMeshProUGUI PriceText;

		private void Start()
		{
		}

		protected override void ProcessDestroy()
		{
		}

		public void InitButonStatus()
		{
		}

		public override void OnBtnClickEvent()
		{
		}

		private void ProcessPurchase(int pRes)
		{
		}
	}
}
