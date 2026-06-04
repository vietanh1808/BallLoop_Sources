using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class EasyBarAsset : MonoBehaviour
{
	private static Dictionary<string, EasyBarAsset> ExistDic;

	public string SelfName;

	[Header("去物品列表GLD查询对应资产id")]
	public string AssetKey;

	private bool m_RecordInDic;

	[Header("使用123.45K这种计数法")]
	public bool UseTextKMStyle;

	public CanvasGroup CanvasGroup;

	public Transform IconTrans;

	public TextMeshProUGUI ValueText;

	public string ValueFormat;

	public GameObject RedPoint;

	private float m_CurValue;

	private float m_ToValue;

	private float m_AddSpeed;

	private float m_TimeCount;

	public bool UseNumberScroll;

	public UnityEvent IconShakeEvent;

	public static EasyBarAsset GetBar(string pName)
	{
		return null;
	}

	public static bool Add(string pName, float pValue, float pEffectDelay = 0f)
	{
		return false;
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

	private void OnAddAssetForBarEvent(string pAsset, float pValue, float pDelay)
	{
	}

	public void ShakeIcon()
	{
	}

	public void AddValue(float pValue, float pEffectDelay = 0f)
	{
	}

	public void UpdateText(float pValue)
	{
	}
}
