using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EasyGame.Base;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameMapSceneMgr : GameSceneBase
{
	[Serializable]
	public class LevelBd
	{
		public TextMeshPro LevelText;

		public SpriteRenderer LevelSp;

		public Renderer BdMod;
	}

	[Serializable]
	public class BotTab
	{
		public GameObject Root;

		public GameObject NameUi;
	}

	[CompilerGenerated]
	private sealed class _003CProcessStartFight_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CProcessStartFight_003Ed__29(int _003C_003E1__state)
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
	private sealed class _003CProcessStartGame_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameMapSceneMgr _003C_003E4__this;

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
		public _003CProcessStartGame_003Ed__23(int _003C_003E1__state)
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

	public static GameMapSceneMgr Instance;

	public float RefreshTimer;

	public static int NewFinishLevel;

	public static int GetLevelReward;

	public EasyPopup ShopPopup;

	public EasyPopup SettingPopup;

	public BotTab[] BotTabUis;

	public Image[] LevelImages;

	public TextMeshProUGUI[] LevelTexts;

	public Sprite[] LevelSps;

	public Sprite[] SphereSps;

	public GameObject SelectGo;

	public GameObject StartBtn;

	public TextMeshProUGUI LevelText;

	public int LvModTurn;

	private int m_CurSelect;

	private EasyPopup m_CurPopup;

	public bool Inited { get; set; }

	protected override void ProcessStart()
	{
	}

	protected override void ProcessDestroy()
	{
	}

	[IteratorStateMachine(typeof(_003CProcessStartGame_003Ed__23))]
	private IEnumerator ProcessStartGame()
	{
		return null;
	}

	private void OnLanguageUpdate()
	{
	}

	private void OnBtnClickEvent(string pName)
	{
	}

	private void ShowPopup(EasyPopup pPopup)
	{
	}

	private void ProcessSelect(int pSelect)
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CProcessStartFight_003Ed__29))]
	private IEnumerator ProcessStartFight()
	{
		return null;
	}

	private void CheckDailyLogic()
	{
	}

	private void OnAssetChangeEvent(string pAsset, float pValue)
	{
	}

	private void OnPurchaseEndEvent(StoreConfigData pData, bool pRes)
	{
	}

	private void CheckBtnState()
	{
	}
}
