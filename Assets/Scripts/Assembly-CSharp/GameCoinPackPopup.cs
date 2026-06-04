using System;
using EasyGame.Base;
using TMPro;
using UnityEngine;

public class GameCoinPackPopup : EasyPopup
{
	[Serializable]
	public class PackUi
	{
		public TextMeshProUGUI RewardText;

		public EasyUiBtnIap IapBtn;

		public GameObject Item;
	}

	public PackUi[] PackUis;

	public override void ProcessStart()
	{
	}

	public override void DestroyPopup()
	{
	}

	private void ProcessPurchaseEnd(StoreConfigData pItem, bool pRes)
	{
	}
}
