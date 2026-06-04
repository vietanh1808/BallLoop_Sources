using System;
using EasyGame.Base;
using TMPro;

public class GameLevelExitPopup : EasyPopup
{
	public TextMeshProUGUI LeaveText;

	public Action<int> ResAc;

	public int ResState;

	public bool CheckLife;

	public override void ProcessStart()
	{
	}

	public override void ClickChildBtn(string pName)
	{
	}

	public override void ClosePopup()
	{
	}
}
