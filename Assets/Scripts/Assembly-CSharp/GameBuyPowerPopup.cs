using EasyGame.Base;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameBuyPowerPopup : EasyPopup
{
	public Image IconImage;

	public GameObject BuyBtn;

	public string CostAsset;

	public int CostValue;

	public int BuyRewardNum;

	public TextMeshProUGUI BuyRewardText;

	public TextMeshProUGUI CostText;

	public GameObject OkBtn;

	public EasyUiBtnRv RvBtn;

	public TextMeshProUGUI RvRewardText;

	public int RvRewardNum;

	public TextMeshProUGUI TimeText;

	public GameObject FullUi;

	public EasyBarPower PowerBar;

	public AssetGld PowerAsset;

	public RectTransform NormalUi;

	public GameObject MaxUi;

	public TextMeshProUGUI MaxTimeText;

	public float RefreshTime;

	public TextMeshProUGUI PowerText;

	public Transform HartRoot;

	public CanvasGroup[] HeartUis;

	public override void ProcessStart()
	{
	}

	public override void ClosePopup()
	{
	}

	private void Update()
	{
	}

	private void CheckUiState()
	{
	}

	public override void ClickChildBtn(string pName)
	{
	}

	private void OnPowerNumUpdateEvent(int pNum)
	{
	}

	private void OnPowerTimeUpdateEvent()
	{
	}

	private void OnRvResultEvent(bool pRes)
	{
	}

	private void ProcessAddPower(int pValue)
	{
	}
}
