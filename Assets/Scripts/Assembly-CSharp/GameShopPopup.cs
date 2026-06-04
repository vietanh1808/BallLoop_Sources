using EasyGame.Base;
using UnityEngine;
using UnityEngine.UI;

public class GameShopPopup : EasyPopup
{
	public static GameShopPopup Instance;

	public ScrollRect ItemScroll;

	public RectTransform ItemRoot;

	public float ScrollHeight;

	public int ToIndex;

	public Transform CoinPackRoot;

	public GameObject RestoreBtn;

	public GameObject CloseBtn;

	protected override void ProcessAwake()
	{
	}

	public override void ProcessStart()
	{
	}

	public void UpdateItems()
	{
	}

	public override void ProcessShowFinished()
	{
	}

	public override void DestroyPopup()
	{
	}

	private void OnDestroy()
	{
	}

	private void ProcessPurchaseRes(bool pReal, StoreConfigData pItem, bool pRes)
	{
	}

	public void ScrollRectTo(int pIndex)
	{
	}
}
