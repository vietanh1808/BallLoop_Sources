using System;
using System.Collections.Generic;
using UnityEngine;

public class PipBroken : MonoBehaviour
{
	public Renderer[] NormalMods;

	public Renderer[] BreakMods;

	public static Action<float> PrepareBreakAc;

	public static Action ShowBreakAc;

	public static Action ResumeAc;

	public List<GameObject> EffectMods;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnPrepareBreakEvent(float tTimer)
	{
	}

	private void OnBreakEvent()
	{
	}

	private void OnResumeEvent()
	{
	}

	[ContextMenu("校正破碎效果")]
	private void CorrectBreakEffect()
	{
	}
}
