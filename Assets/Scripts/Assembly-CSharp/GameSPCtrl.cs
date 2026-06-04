using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

[SelectionBase]
public class GameSPCtrl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public GameSPCtrl _003C_003E4__this;

		public int tNum;

		public int tFinishNum;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass46_0
	{
		public Vector2Int tStartPos;

		public Action<GameObject> _003C_003E9__1;

		internal void _003CProcessJiGuangFaSheQiEffect_003Eb__1(GameObject a)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass50_0
	{
		public NavCell pToCell;

		internal void _003CProcessHuoJianFly_003Eb__0(GameObject a)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass55_0
	{
		public GameSPCtrl _003C_003E4__this;

		public int tFinishNum;
	}

	[CompilerGenerated]
	private sealed class _003CProcessDuanLieLuDuanEffect_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameSPCtrl _003C_003E4__this;

		private GameSPCtrl _003CtSpCtrl_003E5__2;

		private GameObject _003CtExMod_003E5__3;

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
		public _003CProcessDuanLieLuDuanEffect_003Ed__45(int _003C_003E1__state)
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
	private sealed class _003CProcessHuoJianFly_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NavCell pToCell;

		public GameObject pRocket;

		public GameSPCtrl _003C_003E4__this;

		public float pDelay;

		public Vector3 pFromPos;

		private _003C_003Ec__DisplayClass50_0 _003C_003E8__1;

		private GameObject _003CtAnim_003E5__2;

		private Transform _003CtFollowTarget_003E5__3;

		private bool _003CtFly_003E5__4;

		private Vector3 _003CtOldPos_003E5__5;

		private float _003CtTime_003E5__6;

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
		public _003CProcessHuoJianFly_003Ed__50(int _003C_003E1__state)
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
	private sealed class _003CProcessJiGuangFaSheQiEffect_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameSPCtrl _003C_003E4__this;

		private _003C_003Ec__DisplayClass46_0 _003C_003E8__1;

		private Vector2Int _003CtDir_003E5__2;

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
		public _003CProcessJiGuangFaSheQiEffect_003Ed__46(int _003C_003E1__state)
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
	private sealed class _003CProcessMiFengRongQiEffect_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameSPCtrl _003C_003E4__this;

		private List<BeadBox> _003CtBoxList_003E5__2;

		private GameSPCtrl _003CtSpCtrl_003E5__3;

		private BeadExit _003CtRootExit_003E5__4;

		private int _003CtIndex_003E5__5;

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
		public _003CProcessMiFengRongQiEffect_003Ed__47(int _003C_003E1__state)
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
	private sealed class _003CProcessSpYaoShiEffect_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003CProcessSpYaoShiEffect_003Ed__32(int _003C_003E1__state)
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
	private sealed class _003CProcessWaitCreate_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameSPCtrl _003C_003E4__this;

		public List<NavCell> tList;

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
		public _003CProcessWaitCreate_003Ed__37(int _003C_003E1__state)
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
	private sealed class _003CProcessWaitFillTanChuPingTai_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameSPCtrl _003C_003E4__this;

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
		public _003CProcessWaitFillTanChuPingTai_003Ed__44(int _003C_003E1__state)
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
	private sealed class _003CProcessWaitShenMiLiWu_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameSPCtrl _003C_003E4__this;

		public List<NavCell> pList;

		private _003C_003Ec__DisplayClass55_0 _003C_003E8__1;

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
		public _003CProcessWaitShenMiLiWu_003Ed__55(int _003C_003E1__state)
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
	private sealed class _003CProcessZhaDanQiuFire_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameSPCtrl _003C_003E4__this;

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
		public _003CProcessZhaDanQiuFire_003Ed__56(int _003C_003E1__state)
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
	private sealed class _003CTryMoveKongJianSuoCor_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NavCell pLeftCell;

		public GameSPCtrl _003C_003E4__this;

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
		public _003CTryMoveKongJianSuoCor_003Ed__39(int _003C_003E1__state)
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
	private sealed class _003CTryShowMaiChongZhaMen_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameSPCtrl _003C_003E4__this;

		private bool _003CtFree_003E5__2;

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
		public _003CTryShowMaiChongZhaMen_003Ed__59(int _003C_003E1__state)
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

	public SpData SelfData;

	[Header("勾选时会处理数据")]
	public bool ProcessData;

	[Header("处理数据时是否验证来源")]
	public bool ValiteSource;

	[Header("数字文本 没有就不填")]
	public TextMeshPro NumText;

	[Header("目标数变化时")]
	public ParticleSystem NumChangeFx;

	[Header("完成销毁延迟时间")]
	public float DestroyDelay;

	public GameObject[] NormalMods;

	public GameObject[] FinishMods;

	[Header("特殊处理的引用")]
	public GameObject[] ExtraMods;

	[Header("特殊处理的引用")]
	public BoxCollider[] ExtraCols;

	public Animator MainAnim;

	public bool IsFinished;

	private static Dictionary<SpType, List<GameSPCtrl>> FxAudioUniDic;

	private static Dictionary<SpType, float> FxAudioTimerDic;

	private static Dictionary<SpType, float> FinishAudioTimerDic;

	public List<BeadHolder> BeadHList;

	private static List<SpType> BoxFinishTypes;

	private static List<SpType> BeadTapTypes;

	public bool InCreate;

	private static List<SpType> ClearSpTypes;

	private float m_MaiChongZhaMenTimer;

	public GameSP_TanChuPingTaiPanel TanChuPingTaiPanel { get; set; }

	public void Init(SpData pSp)
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetRelateCellType()
	{
	}

	private void OnBeadInWaitEvent(BeadHolder pBox)
	{
	}

	private void OnBeadTapEvent()
	{
	}

	private void OnBoxFinishEvent(BeadBox pBox)
	{
	}

	public void UpdateCurFinishNum(int pValue)
	{
	}

	public void OnUpdateSpAc()
	{
	}

	public void ProcessTap()
	{
	}

	[IteratorStateMachine(typeof(_003CProcessSpYaoShiEffect_003Ed__32))]
	public IEnumerator ProcessSpYaoShiEffect(GameObject pMover)
	{
		return null;
	}

	private void PlayAudio(string pAudioName, bool pIsFinish)
	{
	}

	public void CheckState()
	{
	}

	public void TryCreateBead()
	{
	}

	[IteratorStateMachine(typeof(_003CProcessWaitCreate_003Ed__37))]
	private IEnumerator ProcessWaitCreate(List<NavCell> tList)
	{
		return null;
	}

	public void TryMoveKongJianSuo()
	{
	}

	[IteratorStateMachine(typeof(_003CTryMoveKongJianSuoCor_003Ed__39))]
	private IEnumerator TryMoveKongJianSuoCor(NavCell pLeftCell)
	{
		return null;
	}

	public void CreateFengSuoMuXiangMod()
	{
	}

	private void CreateFengSuoMuXiangCell(int pRow, int pCol)
	{
	}

	public void CreateTanChuPingTaiMod()
	{
	}

	public void TryFillTanChuPingTai()
	{
	}

	[IteratorStateMachine(typeof(_003CProcessWaitFillTanChuPingTai_003Ed__44))]
	private IEnumerator ProcessWaitFillTanChuPingTai()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CProcessDuanLieLuDuanEffect_003Ed__45))]
	public IEnumerator ProcessDuanLieLuDuanEffect(GameSPCtrl pSpCtrl)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CProcessJiGuangFaSheQiEffect_003Ed__46))]
	public IEnumerator ProcessJiGuangFaSheQiEffect()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CProcessMiFengRongQiEffect_003Ed__47))]
	public IEnumerator ProcessMiFengRongQiEffect(GameSPCtrl pSpCtrl)
	{
		return null;
	}

	public void TryCheckHuoJianFaSheQiPath()
	{
	}

	private void ProcessHuoJianFaSheQiEffect()
	{
	}

	[IteratorStateMachine(typeof(_003CProcessHuoJianFly_003Ed__50))]
	private IEnumerator ProcessHuoJianFly(GameObject pRocket, Vector3 pFromPos, NavCell pToCell, float pDelay)
	{
		return null;
	}

	private bool ClearSpByPos(Vector2Int pPos)
	{
		return false;
	}

	public void TryOpenShenMiLiWu()
	{
	}

	private List<NavCell> TryFindCells(Vector2Int pFormPoint, int pNeedCount)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CProcessWaitShenMiLiWu_003Ed__55))]
	private IEnumerator ProcessWaitShenMiLiWu(List<NavCell> pList)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CProcessZhaDanQiuFire_003Ed__56))]
	private IEnumerator ProcessZhaDanQiuFire()
	{
		return null;
	}

	public void SetMaiChongZhaMenDelay(float pDelay)
	{
	}

	[IteratorStateMachine(typeof(_003CTryShowMaiChongZhaMen_003Ed__59))]
	private IEnumerator TryShowMaiChongZhaMen()
	{
		return null;
	}

	public void TryOpenBaoXiang()
	{
	}
}
