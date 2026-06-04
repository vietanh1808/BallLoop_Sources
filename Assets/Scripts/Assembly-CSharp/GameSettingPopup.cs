using System.Collections.Generic;
using EasyGame.Base;
using TMPro;
using UnityEngine;

public class GameSettingPopup : EasyPopup
{
	public GameObject[] LevelUis;

	public GameObject RestoreBtn;

	public GameObject HomeBtn;

	public GameObject RetryBtn;

	[Header("语言")]
	public TextMeshProUGUI LangText;

	public Dictionary<SystemLanguage, string> SupportLangs;

	public int CurLangIndex;

	public override void ProcessStart()
	{
	}

	public override void ClickChildBtn(string pName)
	{
	}

	private void ProcessExitPlay(SceneId pSceneId)
	{
	}
}
