using System.Collections.Generic;
using EasyGame.Base;
using TMPro;
using UnityEngine.UI;

public class GameDebugPopup : EasyPopup
{
	public int ShowType;

	public TMP_InputField GoldInput;

	public TMP_InputField PowerInput;

	public TMP_InputField VibrateRigidInput;

	public TMP_InputField VibrateSoftInput;

	public TMP_InputField TestLevelInput;

	public TMP_InputField DayInput;

	public TMP_InputField HourInput;

	public TMP_InputField MinInput;

	public TMP_InputField SecInput;

	public TextMeshProUGUI CurTimeText;

	public Toggle Toggle_SkipFtue;

	public Dictionary<string, string> OpeIds;

	public override void ProcessStart()
	{
	}

	public override void DestroyPopup()
	{
	}

	public override void ClickChildBtn(string pName)
	{
	}

	private void UpdateTimeOffset()
	{
	}

	private void SetTimeOffset()
	{
	}
}
