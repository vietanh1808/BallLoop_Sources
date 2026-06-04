using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EasyGame.Base;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameLevelDifficultyEffectPopup : EasyPopup
{
	[CompilerGenerated]
	private sealed class _003CProcessShowHideEffect_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameLevelDifficultyEffectPopup _003C_003E4__this;

		private float _003CtAnimTime_003E5__2;

		private Vector3 _003CtPos1_003E5__3;

		private Vector3 _003CtPos2_003E5__4;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CProcessShowHideEffect_003Ed__17(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public LevelGld SelfLevel;

	public CanvasGroup MoveCanvas;

	public Transform[] MoveTrans;

	public float MoveSpeed;

	public float LimitX;

	public Image IconImage;

	public TextMeshProUGUI DiffText;

	public TextMeshProUGUI DiffText2;

	public Image BgImg;

	public Image[] TagImgs;

	public Sprite[] IconSps;

	public Sprite[] BgSps;

	public Sprite[] TagSps;

	public GameObject[] DiffFx;

	public float AnimWaitTime;

	public override void ProcessStart()
	{
	}

	public override void ProcessShowFinished()
	{
	}

	[IteratorStateMachine(typeof(_003CProcessShowHideEffect_003Ed__17))]
	private IEnumerator ProcessShowHideEffect()
	{
		return null;
	}
}
