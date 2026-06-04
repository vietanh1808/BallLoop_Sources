using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EasyGame.Base;
using UnityEngine;

public class GameFtueTipPopup : EasyPopup
{
	[CompilerGenerated]
	private sealed class _003CUISpotLight_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameFtueTipPopup _003C_003E4__this;

		private Material _003Cmaterial_003E5__2;

		private float _003C_Radius_003E5__3;

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
		public _003CUISpotLight_003Ed__6(int _003C_003E1__state)
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

	public GameObject TargetModel;

	public GameObject TipRoot;

	public float TimeCount;

	public float tPosY;

	public GameObject spotLight;

	public override void ProcessStart()
	{
	}

	[IteratorStateMachine(typeof(_003CUISpotLight_003Ed__6))]
	private IEnumerator UISpotLight()
	{
		return null;
	}

	private void Update()
	{
	}

	public override void ClickChildBtn(string pName)
	{
	}

	public override bool ProcessEscapeKey()
	{
		return false;
	}
}
