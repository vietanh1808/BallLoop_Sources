using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EasyGame.Base;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameDialogPopup : EasyPopup
{
	[CompilerGenerated]
	private sealed class _003CShowDialog_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameDialogPopup _003C_003E4__this;

		private float _003CtTimer_003E5__2;

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
		public _003CShowDialog_003Ed__14(int _003C_003E1__state)
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

	public Transform BottomRoot;

	public Image RoleImage;

	public TextMeshProUGUI RoleNameText;

	public GameObject DialogRoot;

	public TextMeshProUGUI DialogText;

	public List<string> DialogContents;

	public int CurState;

	public int MaxCharactierIndex;

	public int CurCharactierIndex;

	public float TimeCount;

	public string DialogPlace;

	public int RoleIndex;

	public Sprite[] RoleSprites;

	public override void ProcessStart()
	{
	}

	[IteratorStateMachine(typeof(_003CShowDialog_003Ed__14))]
	private IEnumerator ShowDialog()
	{
		return null;
	}

	private void ChangeRoleSprite()
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
