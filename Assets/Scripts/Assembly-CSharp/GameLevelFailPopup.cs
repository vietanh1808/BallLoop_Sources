using System;
using EasyGame.Base;
using TMPro;
using UnityEngine;

public class GameLevelFailPopup : EasyPopup
{
	private int m_ResState;

	public Action<int> ResAc;

	public TextMeshProUGUI TitleText;

	[Header("体力为0时")]
	public GameObject RootUi1;

	[Header("体力大于0时")]
	public GameObject RootUi2;

	public EasyBarPower PowerBar;

	public AssetGld PowerAsset;

	public EasyUiBtnRv RvBtn;

	public EasyUiBtnRv RvBotBtn;

	public TextMeshProUGUI RvRewardText;

	public int RvRewardNum;

	public string CostAsset;

	public int CostValue;

	public int BuyRewardNum;

	public TextMeshProUGUI BuyRewardText;

	public TextMeshProUGUI CostText;

	public Transform HartRoot;

	public CanvasGroup[] HeartUis;

	public override void ProcessStart()
	{
	}

	public override void ProcessShowFinished()
	{
	}

	private void OnRvResultEvent(bool pRes)
	{
	}

	private void OnPowerNumUpdateEvent(int pNum)
	{
	}

	public override void ClickChildBtn(string pName)
	{
	}

	public override void ClosePopup()
	{
	}
}
