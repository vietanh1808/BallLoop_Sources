using EasyGame.Base;
using TMPro;
using UnityEngine;

public class GameNoAdsPopup : EasyPopup
{
	public CanvasGroup CloseBtn;

	public TextMeshProUGUI TipText;

	public override void ProcessStart()
	{
	}

	public override void ProcessShowFinished()
	{
	}

	public override void ClosePopup()
	{
	}

	private void OnPurchaseEndEvent(StoreConfigData pData, bool pRes)
	{
	}
}
