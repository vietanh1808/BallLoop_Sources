using EasyGame.Base;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class GameVersionView : EasyUiBtn
{
	private float m_TimeCount;

	private int m_Count;

	public int TapCount;

	public float DurationCount;

	private void Start()
	{
	}

	public override void OnBtnClickEvent()
	{
	}

	private void ShowVersionText()
	{
	}
}
