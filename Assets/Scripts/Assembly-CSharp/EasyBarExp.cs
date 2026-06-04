using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EasyBarExp : MonoBehaviour
{
	[Serializable]
	public class EffectData
	{
		public int Type;

		public int FromLv;

		public int ToLv;

		public int FromExp;

		public int ToExp;
	}

	private static Dictionary<string, EasyBarExp> ExistBar;

	public string SelfName;

	[Header("去物品列表GLD查询对应资产id")]
	public string ExpName;

	private bool m_RecordInDic;

	[Header("使用123.45K这种计数法")]
	public bool UseTextKMStyle;

	public Transform IconTrans;

	public TextMeshProUGUI LvText;

	public Slider ExpSlider;

	public TextMeshProUGUI ValueText;

	[Header("进度条最大显示值")]
	public float ProgressMax;

	private int m_CurValue;

	private int m_CurLv;

	private float m_TimeCount;

	public int EffectState;

	public List<EffectData> EffectList;

	public bool UseNumberScroll;

	public float ParticleStartEulr;

	public ParticleSystem ProgressParticle;

	public static EasyBarExp GetBar(string pName)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Init()
	{
	}

	public void ForceRefresh()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void OnAddExpForBarEvent(string pAsset, int pValue, float pDelay)
	{
	}

	public void ShakeIcon()
	{
	}

	public void AddValue(int pValue, float pEffectDelay = 0f)
	{
	}

	public void UpdateText(int pLv, int pExp)
	{
	}
}
