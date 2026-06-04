using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EasyGame.Base;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameMgr : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CLoadScene_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SceneId pScene;

		public GameMgr _003C_003E4__this;

		private bool _003CtGameStart_003E5__2;

		private GameLoadingPopup _003CtPopup_003E5__3;

		private float _003CtStartValue_003E5__4;

		private float _003CtEndValue_003E5__5;

		private AsyncOperation _003CtOpe_003E5__6;

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
		public _003CLoadScene_003Ed__32(int _003C_003E1__state)
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
	private sealed class _003CPrepareStartGame_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameMgr _003C_003E4__this;

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
		public _003CPrepareStartGame_003Ed__18(int _003C_003E1__state)
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
	private sealed class _003CProcessWaitFrame_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int pFrame;

		public Action pAc;

		private int _003Ci_003E5__2;

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
		public _003CProcessWaitFrame_003Ed__58(int _003C_003E1__state)
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

	public static GameMgr Instance;

	public static float CamViewFactor;

	public static Camera MainCam;

	public static Vector2 CanvasSize;

	public Vector3 TapStartVec;

	public static bool EnableAutoPop;

	private float m_TimeCount;

	private List<EasyPopupQue> m_PopQue;

	private static EventSystem m_EventSystem;

	public static float TouchEnableTimer;

	public static bool InLoading;

	public static bool WaitSceneInit;

	public static float AssetPercent;

	public static SceneId CurSceneId;

	public static SceneId LastSceneId;

	public GameLoadingPopup CurLoadingPop;

	public static bool UseBlackLoading;

	private float m_InterstitalTimerRv;

	public static float InterstitialIntervalRv;

	private float m_InterstitalTimerInt;

	public static float InterstitialIntervalInt;

	public static bool InterstitialIsOn;

	public static bool WatchingRv;

	public static int WatchRvNum;

	public static bool ShouldShowIntAd;

	public int PopQueCount => 0;

	public static EventSystem CurEventSystem => null;

	public static int InterstitialWatchSum
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnApplicationPause(bool pause)
	{
	}

	private void OnApplicationFocus(bool focus)
	{
	}

	public void AddPop(EasyPopupQue pPop, bool pCanRepeat = true)
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CPrepareStartGame_003Ed__18))]
	private IEnumerator PrepareStartGame()
	{
		return null;
	}

	public static void SetUiTouchDelay(float pTime = 0f)
	{
	}

	public void EnterScene(SceneId pScene)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadScene_003Ed__32))]
	private IEnumerator LoadScene(SceneId pScene)
	{
		return null;
	}

	private void OnBtnClickEvent(string pName)
	{
	}

	private void OnTip(string pTip)
	{
	}

	private void OnRestoreEvent(bool pRes)
	{
	}

	private void OnPopShow(EasyPopup pPop)
	{
	}

	private void OnPopClose(EasyPopup pPop)
	{
	}

	private void OnRvBtnAppearEvent(EasyAdsState pState, string pPlace)
	{
	}

	private void OnRvStateEvent(EasyAdsState pState, bool pReal)
	{
	}

	private void OnInterstitialStateEvent(EasyAdsState pData)
	{
	}

	public bool ProcessBackKeyEvent()
	{
		return false;
	}

	public static void VibrateHeavy()
	{
	}

	public static void VibrateMedium()
	{
	}

	public static void VibrateLight()
	{
	}

	public static void VibrateSoft()
	{
	}

	public static void VibrateRigid()
	{
	}

	public static void VibrateSuccess()
	{
	}

	public static void VibrateFailure()
	{
	}

	public static void Load<T>(string pName, Action<T> pAc) where T : UnityEngine.Object
	{
	}

	public static void WaitForFrame(Action pAc, int pFrame = 1)
	{
	}

	[IteratorStateMachine(typeof(_003CProcessWaitFrame_003Ed__58))]
	private static IEnumerator ProcessWaitFrame(Action pAc, int pFrame = 1)
	{
		return null;
	}

	public static void AddReward(AssetChangeData pData, bool pSave = true, float pUpdateBar = 0f)
	{
	}

	public static bool TryShowInterstitial(string pPlace)
	{
		return false;
	}
}
