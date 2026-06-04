using EasyGame.Base;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameShopAssetItem : MonoBehaviour
{
	public ShopGld SelfGld;

	public Image IconImage;

	public TextMeshProUGUI NameText;

	public TextMeshProUGUI RewardText;

	public GameObject DiscountUi;

	public EasyUiBtnIap IapBtn;

	public GameObject AnimItem;

	public void Init(ShopGld pGld, int pIndex)
	{
	}

	public void UpdateUis()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnIapPurchaseEnd(StoreConfigData pConfig, bool pRes)
	{
	}
}
