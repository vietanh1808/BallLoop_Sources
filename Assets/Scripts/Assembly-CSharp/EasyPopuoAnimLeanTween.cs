using System;
using EasyGame.Base;
using UnityEngine;

public class EasyPopuoAnimLeanTween : EasyPopupAnim
{
	[Header("*: 忽略时间缩放")]
	public bool IgnoreTimeScale;

	[Header("x: 透明度动画")]
	public bool UseAlpha;

	public float AlphaTime;

	public LeanTweenType AlphaShowType;

	public LeanTweenType AlphaHideType;

	[Header("x: 缩放动画")]
	public bool UseScale;

	public float ScaleTime;

	public LeanTweenType ScaleShowType;

	public LeanTweenType ScaleHideType;

	[Header("x: 出现动画")]
	public bool UseMove;

	public float MoveTime;

	public float MoveY;

	public LeanTweenType MoveShowType;

	public LeanTweenType MoveHideType;

	public float MaxAnimTime => 0f;

	public override void Show(Action pEndAc)
	{
	}

	public override void Hide(Action pEndAc)
	{
	}
}
