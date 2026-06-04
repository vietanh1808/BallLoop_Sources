using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EasyGame.Base;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameLevelCompletePopup : EasyPopup
{
	[CompilerGenerated]
	private sealed class _003CProcessRewardEffect_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameLevelCompletePopup _003C_003E4__this;

		public bool pRv;

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
		public _003CProcessRewardEffect_003Ed__23(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CShowSampleEffect_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameLevelCompletePopup _003C_003E4__this;

		private int _003CtCurLevel_003E5__2;

		private int[] _003CtUnlockVec_003E5__3;

		private float _003CtStartPercent_003E5__4;

		private float _003CtToPercent_003E5__5;

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
		public _003CShowSampleEffect_003Ed__19(int _003C_003E1__state)
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

	private int m_ResState;

	public Action<int> ResAc;

	[Header("中间解锁新特性的节点")]
	public GameObject SpUnlockRoot;

	public GameObject LightRoot;

	public Image[] SpUnlockIconImages;

	public TextMeshProUGUI SpUnlockLvText;

	public TextMeshProUGUI SpProgressText;

	public Slider SpProgressSlider;

	public Image SpFillImage;

	public int RewardNum;

	public Transform RewardIcon;

	public TextMeshProUGUI RewardText;

	public Transform RewardIcon2;

	public TextMeshProUGUI RewardText2;

	[Header("底部各个按钮")]
	public Transform BtnRoot;

	public EasyUiBtnRv RvBtn;

	public Animator GiftAnim;

	public override void ProcessStart()
	{
	}

	public override void ProcessShowFinished()
	{
	}

	[IteratorStateMachine(typeof(_003CShowSampleEffect_003Ed__19))]
	private IEnumerator ShowSampleEffect()
	{
		return null;
	}

	private void OnRvResultEvent(bool pRes)
	{
	}

	public override void ClickChildBtn(string pName)
	{
	}

	public override void DestroyPopup()
	{
	}

	[IteratorStateMachine(typeof(_003CProcessRewardEffect_003Ed__23))]
	private IEnumerator ProcessRewardEffect(bool pRv)
	{
		return null;
	}
}
