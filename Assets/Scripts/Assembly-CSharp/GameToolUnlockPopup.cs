using EasyGame.Base;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameToolUnlockPopup : EasyPopup
{
	public string AssetKey;

	public TextMeshProUGUI TitleText;

	public TextMeshProUGUI DesText;

	public GameObject IconLight;

	public Canvas IconUi;

	public Image IconImage;

	public Transform GiftRoot;

	public CanvasGroup CloseCanvas;

	public override void ProcessStart()
	{
	}

	public override void ProcessShowFinished()
	{
	}
}
