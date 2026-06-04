using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using Voodoo.Sauce.Core;

public class GameInitSceneManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CProcessStartGame_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameInitSceneManager _003C_003E4__this;

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
		public _003CProcessStartGame_003Ed__4(int _003C_003E1__state)
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

	public GameObject GameServicePrefab;

	public GameObject GameManagerPrefab;

	private bool m_IsInitFinished;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CProcessStartGame_003Ed__4))]
	private IEnumerator ProcessStartGame()
	{
		return null;
	}

	private void VoodooSauceInitCallback(VoodooSauceInitCallbackResult pResult)
	{
	}
}
