using EasyGame.Base;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameBuyToolPopup : EasyPopup
{
	public string AssetKey;

	public TextMeshProUGUI NameText;

	public TextMeshProUGUI DesText;

	public Image[] IconsImages;

	public GameObject CostBtn;

	public string CostAsset;

	public int CostValue;

	public TextMeshProUGUI CostText;

	public TextMeshProUGUI RewardByCoinText;

	public int RewadByCoinNum;

	public override void ProcessStart()
	{
	}

	public override void ClickChildBtn(string pName)
	{
	}
}
