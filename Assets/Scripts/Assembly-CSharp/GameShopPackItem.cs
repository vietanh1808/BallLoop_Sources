using TMPro;
using UnityEngine;

public class GameShopPackItem : MonoBehaviour
{
	public string StoreId;

	public bool CanSpriteNum;

	public TextMeshProUGUI NameText;

	public TextMeshProUGUI CoinText;

	public TextMeshProUGUI DiscountText;

	public TextMeshProUGUI LifeTimeText;

	public TextMeshProUGUI ToolNumText1;

	public TextMeshProUGUI ToolNumText2;

	public TextMeshProUGUI ToolNumText3;

	public GameObject[] Items;

	private void Start()
	{
	}

	public void UpdateUis()
	{
	}

	private string GetAssetStr(string pKey, float pNum)
	{
		return null;
	}
}
