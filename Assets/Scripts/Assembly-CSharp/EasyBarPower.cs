using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class EasyBarPower : MonoBehaviour
{
	private static Dictionary<string, EasyBarPower> ExistBar;

	public string SelfName;

	[Header("去物品列表GLD查询对应资产id")]
	public string PowerName;

	private bool m_RecordInDic;

	[Header("能量填充时间(秒)")]
	public int FillTime;

	[Header("是否开启自动填充")]
	public bool EnableAutoFill;

	public int MaxPower;

	public Transform IconTrans;

	public TextMeshProUGUI ValueText;

	public string ValueFormat;

	public GameObject FullUi;

	public TextMeshProUGUI TimerText;

	public string TimerFormat;

	public GameObject TimeUiRoot;

	public Image ProgressBar;

	public TextMeshProUGUI ProgressText;

	public CanvasGroup CanvasGroup;

	public IEasyBarPowerItem[] ItemsList;

	public UnityEvent IconShakeEvent;

	public Action<int> UpdateNumAc;

	public Action UpdateTimerAc;

	public GameObject MaxIcon;

	public float Timer;

	public static EasyBarPower GetBar(string pName)
	{
		return null;
	}

	public static bool Add(string pName, int pValue, float pEffectDelay = 0f)
	{
		return false;
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void UpdateLifeState()
	{
	}

	private void UpdateProgress(float pProgress)
	{
	}

	private void OnAddPowerEvent(string pPower, int pValue, float pDelay)
	{
	}

	public void Add(int pCount, float pDelay = 0f)
	{
	}

	public void ShakeIcon()
	{
	}
}
