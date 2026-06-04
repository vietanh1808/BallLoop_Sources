using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EasyGame.Base;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameLevelSceneMgr : GameSceneBase
{
	[Serializable]
	public class GroupPath
	{
		public List<BeadHolder> Beads;

		public int DefaultPointNum;

		public bool Finish;
	}

	[Serializable]
	public class ToolBtnUi
	{
		public string AssetKey;

		public int UnlockLevel;

		public GameObject BtnUi;

		public Image IconImage;

		public GameObject UnlockUi;

		public GameObject NumTag;

		public GameObject AddTag;

		public GameObject LockUi;

		public TextMeshProUGUI LockText;

		public bool Init;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_1
	{
		public ToolBtnUi tTool;

		public bool tWait;

		public Canvas tIconUi;

		internal void _003CProcessStartGame_003Eb__2(EasyPopup a)
		{
		}

		internal void _003CProcessStartGame_003Eb__1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public GameFtueHandPopup tHandPop;

		public CanvasGroup tCloseCanvas;

		internal void _003CProcessFtue1_003Eb__0()
		{
		}

		internal void _003CProcessFtue1_003Eb__1()
		{
		}

		internal void _003CProcessFtue1_003Eb__2()
		{
		}

		internal void _003CProcessFtue1_003Eb__3()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_1
	{
		public TextMeshProUGUI tText;

		internal void _003CProcessFtue1_003Eb__4(float a)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_2
	{
		public TextMeshProUGUI tText;

		internal void _003CProcessFtue1_003Eb__5(float a)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_3
	{
		public TextMeshProUGUI tText;

		internal void _003CProcessFtue1_003Eb__6(float a)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_4
	{
		public TextMeshProUGUI tText;

		internal void _003CProcessFtue1_003Eb__7(float a)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public TextMeshProUGUI tText;

		public CanvasGroup tCloseCanvas;

		internal void _003CProcessFtue2_003Eb__0(float a)
		{
		}

		internal void _003CProcessFtue2_003Eb__1()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public GameLevelSceneMgr _003C_003E4__this;

		public CanvasGroup tUiCanvas;

		internal void _003CProcessDifficultyAnim_003Eb__0(GameObject a)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public int tRes;

		internal void _003CProcessLevelComplete_003Eb__0(int a)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass38_0
	{
		public int tRevivalRes;

		internal void _003CProcessLevelFail_003Eb__0(int a)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass38_1
	{
		public int tFailState;

		internal void _003CProcessLevelFail_003Eb__1(int a)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public BeadHolder tBead;

		public GameToolSelectPopup tPop;

		public int tRes;

		internal void _003CProcessTool_003Eb__0(int a)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CCreateLevel_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameLevelSceneMgr _003C_003E4__this;

		private TextAsset _003CtLevelConfig_003E5__2;

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
		public _003CCreateLevel_003Ed__29(int _003C_003E1__state)
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
	private sealed class _003CProcessDifficultyAnim_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameLevelSceneMgr _003C_003E4__this;

		private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

		private GameLevelDifficultyEffectPopup _003CtDiffPop_003E5__2;

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
		public _003CProcessDifficultyAnim_003Ed__27(int _003C_003E1__state)
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
	private sealed class _003CProcessFtue1_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private _003C_003Ec__DisplayClass20_1 _003C_003E8__1;

		private _003C_003Ec__DisplayClass20_0 _003C_003E8__2;

		private _003C_003Ec__DisplayClass20_2 _003C_003E8__3;

		public GameLevelSceneMgr _003C_003E4__this;

		private _003C_003Ec__DisplayClass20_3 _003C_003E8__4;

		private _003C_003Ec__DisplayClass20_4 _003C_003E8__5;

		private BeadExit _003CtExit_003E5__2;

		private BeadHolder _003CtBall_003E5__3;

		private int _003CtTo_003E5__4;

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
		public _003CProcessFtue1_003Ed__20(int _003C_003E1__state)
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
	private sealed class _003CProcessFtue2_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string pText;

		private _003C_003Ec__DisplayClass21_0 _003C_003E8__1;

		private int _003CtTo_003E5__2;

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
		public _003CProcessFtue2_003Ed__21(int _003C_003E1__state)
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
	private sealed class _003CProcessLevelComplete_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameLevelSceneMgr _003C_003E4__this;

		private _003C_003Ec__DisplayClass37_0 _003C_003E8__1;

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
		public _003CProcessLevelComplete_003Ed__37(int _003C_003E1__state)
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
	private sealed class _003CProcessLevelFail_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameLevelSceneMgr _003C_003E4__this;

		public bool pShowPop;

		private _003C_003Ec__DisplayClass38_0 _003C_003E8__1;

		private _003C_003Ec__DisplayClass38_1 _003C_003E8__2;

		private float _003CtWaitTime_003E5__2;

		private List<BeadHolder> _003CtBHList_003E5__3;

		private int _003CtCurSteakNum_003E5__4;

		private GameLevelRevivalPopup _003CtRevivalPop_003E5__5;

		private GameLevelFailPopup _003CtFailPop_003E5__6;

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
		public _003CProcessLevelFail_003Ed__38(int _003C_003E1__state)
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
	private sealed class _003CProcessRevival_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameLevelSceneMgr _003C_003E4__this;

		private List<BeadHolder> _003CtList_003E5__2;

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
		public _003CProcessRevival_003Ed__39(int _003C_003E1__state)
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
	private sealed class _003CProcessSelecBeadHolder_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<BeadHolder> pList;

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
		public _003CProcessSelecBeadHolder_003Ed__34(int _003C_003E1__state)
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
	private sealed class _003CProcessStartGame_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameLevelSceneMgr _003C_003E4__this;

		private _003C_003Ec__DisplayClass18_1 _003C_003E8__1;

		private Animator _003CtCamAnim_003E5__2;

		private GameToolUnlockPopup _003CtPop_003E5__3;

		private int _003Ci_003E5__4;

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
		public _003CProcessStartGame_003Ed__18(int _003C_003E1__state)
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
	private sealed class _003CProcessTool_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<int> pUseResAc;

		public string pTool;

		public GameLevelSceneMgr _003C_003E4__this;

		private _003C_003Ec__DisplayClass41_0 _003C_003E8__1;

		private List<BeadHolder> _003CtList_003E5__2;

		private List<BeadExit> _003CtChangeExits_003E5__3;

		private float _003CtMoveTime_003E5__4;

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
		public _003CProcessTool_003Ed__41(int _003C_003E1__state)
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
	private sealed class _003CProcessVideo5_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003CProcessVideo5_003Ed__24(int _003C_003E1__state)
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

	public static GameLevelSceneMgr Ins;

	public LevelGld CurLevelGld;

	public CanvasGroup UiRootCanvas;

	public Image LevelBg;

	public TextMeshProUGUI LevelText;

	public bool Inited;

	public int CurState;

	public CanvasGroup ToolRootCanvas;

	public ToolBtnUi[] ToolUis;

	public GameOperationControl OpeCtrl;

	public bool NeedUpdateCellPath;

	public bool ShouldCheckResult;

	public TextMeshProUGUI FinishText;

	public ParticleSystem FinishFx;

	public int RevivalSum;

	public bool AllBallInPip;

	private static int IntAdLevel;

	protected override void ProcessAwake()
	{
	}

	protected override void ProcessStart()
	{
	}

	protected override void ProcessDestroy()
	{
	}

	[IteratorStateMachine(typeof(_003CProcessStartGame_003Ed__18))]
	private IEnumerator ProcessStartGame()
	{
		return null;
	}

	private void OnLanguageUpdate()
	{
	}

	[IteratorStateMachine(typeof(_003CProcessFtue1_003Ed__20))]
	private IEnumerator ProcessFtue1()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CProcessFtue2_003Ed__21))]
	private IEnumerator ProcessFtue2(string pText)
	{
		return null;
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CProcessVideo5_003Ed__24))]
	private IEnumerator ProcessVideo5()
	{
		return null;
	}

	private void OnBtnClickEvent(string pBtnName)
	{
	}

	private void ProcessRetry()
	{
	}

	[IteratorStateMachine(typeof(_003CProcessDifficultyAnim_003Ed__27))]
	private IEnumerator ProcessDifficultyAnim()
	{
		return null;
	}

	public static int GetToLevel(int pCurLevel)
	{
		return 0;
	}

	[IteratorStateMachine(typeof(_003CCreateLevel_003Ed__29))]
	public IEnumerator CreateLevel()
	{
		return null;
	}

	private void OnOpePressEvent(bool pPress, PointerEventData pData)
	{
	}

	private void TrySelectBead(BeadHolder pBead)
	{
	}

	private List<BeadHolder> FindSpYinLiList(List<BeadHolder> pList)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CProcessSelecBeadHolder_003Ed__34))]
	private IEnumerator ProcessSelecBeadHolder(List<BeadHolder> pList)
	{
		return null;
	}

	public void CheckLevelResult()
	{
	}

	[IteratorStateMachine(typeof(_003CProcessLevelComplete_003Ed__37))]
	public IEnumerator ProcessLevelComplete()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CProcessLevelFail_003Ed__38))]
	public IEnumerator ProcessLevelFail(bool pShowPop = true)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CProcessRevival_003Ed__39))]
	private IEnumerator ProcessRevival()
	{
		return null;
	}

	private void ProcessRevival1()
	{
	}

	[IteratorStateMachine(typeof(_003CProcessTool_003Ed__41))]
	private IEnumerator ProcessTool(string pTool, Action<int> pUseResAc = null)
	{
		return null;
	}

	public void OnAssetChangeEvent(string pType, float pValue)
	{
	}
}
