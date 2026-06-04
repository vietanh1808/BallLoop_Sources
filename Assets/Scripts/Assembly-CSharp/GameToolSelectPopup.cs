using System;
using EasyGame.Base;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameToolSelectPopup : EasyPopup
{
	public string AssetKey;

	public GameOperationControl OpeCtrl;

	public TextMeshProUGUI NameText;

	public TextMeshProUGUI DesText;

	public GameObject BgRoot;

	public GameObject MaskUi_01;

	public GameObject MaskUi_02;

	public Action<int> ResAc;

	private int m_Res;

	public BeadHolder SelectBead;

	public override void ProcessStart()
	{
	}

	public override void ProcessShowFinished()
	{
	}

	private void OnOpePressEvent(bool pPress, PointerEventData pData)
	{
	}

	public override void ClickChildBtn(string pName)
	{
	}
}
