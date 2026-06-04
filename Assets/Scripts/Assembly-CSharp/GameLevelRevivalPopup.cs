using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EasyGame.Base;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameLevelRevivalPopup : EasyPopup
{
	[CompilerGenerated]
	private sealed class _003CShowWinSteakEffect_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameLevelRevivalPopup _003C_003E4__this;

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
		public _003CShowWinSteakEffect_003Ed__20(int _003C_003E1__state)
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

	[Header("复活ui节点")]
	public GameObject WinSteakRoot;

	public Animator WinSteakAnim;

	public GameObject LifeTipRoot;

	public GameObject[] Roots;

	public GameObject[] PackRoots;

	public TextMeshProUGUI TipText;

	public int CurState;

	[Header("消耗金币复活")]
	public GameObject CostBtn;

	public TextMeshProUGUI[] CostText;

	public int RevivalCostCoin;

	public EasyUiBtnRv RvBtn;

	public GameObject[] BotBtns;

	public GameObject[] ExtraUis;

	public Image BgImg;

	public Sprite[] BgSprites;

	public GameShopPackItem[] PackItems;

	public override void ProcessStart()
	{
	}

	public override void ProcessShowFinished()
	{
	}

	[IteratorStateMachine(typeof(_003CShowWinSteakEffect_003Ed__20))]
	private IEnumerator ShowWinSteakEffect()
	{
		return null;
	}

	public override void DestroyPopup()
	{
	}

	public override void ClickChildBtn(string pName)
	{
	}

	private void ProcessPurchaseRes(bool pReal, StoreConfigData pItem, bool pRes)
	{
	}

	private void OnRvResultEvent(bool pRes)
	{
	}

	private void ProcessRevivalReward(string pAssetUsed)
	{
	}
}
