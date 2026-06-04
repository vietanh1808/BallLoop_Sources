using System;
using UnityEngine;
using UnityEngine.UI;

public class ComFlyIconTool : MonoBehaviour
{
	public Image IconImage;

	public bool IsWorldStartPos;

	public Vector3 StartPos;

	public Vector3 EndPos;

	public bool IsWorldEndPos;

	public float AppearDelayTime;

	[Header("出现数量随机范围")]
	public Vector2 AppearAmountVec;

	[Header("两个出现的间隔")]
	public float AppearDuration;

	[Header("图标会缩放值的数量随机占比")]
	public Vector2 IconScalePercent;

	[Header("图标大小随机的范围")]
	public Vector2 IconScaleVec;

	[Header("出现范围,左右上下")]
	public Vector4 RandomVec;

	[Header("出现时间")]
	public float AppearTime;

	[Header("出现方式 自定义还是插件的 ")]
	public bool AppearAnimByCustom;

	public LeanTweenType AppearType;

	public AnimationCurve AppearCurve;

	[Header("飞行延迟")]
	public float MoveDelayTime;

	[Header("飞行速度")]
	public float MoveTime;

	[Header("飞行曲线 自定义还是插件的")]
	public bool MoveAnimByCustom;

	public LeanTweenType MoveType;

	public AnimationCurve MoveCurve;

	public bool DistanceTime;

	public bool DestoryOnEnd;

	public bool MoveHide;

	public Action OnAnimCompleteAc;

	public void StartFly()
	{
	}

	private void OnAppearFinished()
	{
	}

	private void OnAnimComplete()
	{
	}

	public static ComFlyIconTool Create(string pType, Transform pParent)
	{
		return null;
	}

	public static void FlyIcon(string pIcon, Vector3 pStartPos, Vector3 pEndPos, bool pIsLocal = false)
	{
	}

	public static void FlyIcon(Sprite pIcon, Vector3 pStartPos, Vector3 pEndPos, bool pIsLocal = false)
	{
	}

	public static void FlyIcon3(Sprite pIcon, Vector3 pStartPos, Vector3 pEndPos, bool pIsLocal = false)
	{
	}

	public static void FlyIcon2(string pIcon, Vector3 pStartPos, Vector3 pEndPos, bool pIsLocal = false)
	{
	}

	public static void FlyExpIcon(Vector3 pStartPos, Vector3 pEndPos, bool pIsLocal = false)
	{
	}

	public static ComFlyIconTool FlyPropIcon(string pIcon, Vector3 pStartPos, Vector3 pEndPos, bool pIsLocal = false, Action pCallBack = null)
	{
		return null;
	}
}
