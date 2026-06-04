using System;
using EasyGame.Base;
using UnityEngine;

public class GameFtueHandPopup : EasyPopup
{
	public GameObject TargetUi;

	public GameObject TipRoot;

	public GameObject HandRoot;

	public float TimeCount;

	public RectTransform BtnRect;

	[Header("背景板")]
	public RectTransform BgRect;

	public RectTransform BgCircle;

	public bool IsRound;

	public int MaxTipCount;

	public Action ClickHandAc;

	public override void ProcessStart()
	{
	}

	public void SetTargetState(Vector3 pPos, Vector2 pSize, Vector3 pHandPosOffSet, Vector3 pHandEulrOffset)
	{
	}

	public void SetTargetState(Vector3 pPos, float pScale, Vector3 pHandPosOffSet, Vector3 pHandEulrOffset)
	{
	}

	private void Update()
	{
	}

	public override void ClickChildBtn(string pName)
	{
	}

	public override bool ProcessEscapeKey()
	{
		return false;
	}
}
