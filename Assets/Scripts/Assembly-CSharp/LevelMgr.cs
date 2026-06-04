using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
public class LevelMgr : MonoBehaviour
{
	[Serializable]
	public class CamInfoData
	{
		[Header("镜头位置")]
		public Vector3 EndCamPos;

		[Header("镜头缩放orthographicSize")]
		public float EndCamOrSize;

		[Header("镜头过渡动画 x:延迟开始 y:时长 (0,0为无动画)")]
		public Vector2 AnimTime;
	}

	private class LevelConfig
	{
		public int X;

		public int Y;

		public List<int> W;

		public PipeName Pip;

		public List<BeadConfig> Beads;

		public List<SpData> SpC;

		public List<ExitConfig> Exits;
	}

	private class BeadConfig
	{
		public ColorType Color;

		public int X;

		public int Y;

		public List<BeadHolder.BeadSp> Sps;
	}

	private class ExitConfig
	{
		public List<BeadExit.ExitSp> Sps;

		public List<BoxConfig> Box;
	}

	private class BoxConfig
	{
		public ColorType Color;

		public BoxCapType Cap;

		public List<BeadBox.BoxSp> Sps;
	}

	[CompilerGenerated]
	private sealed class _003CInit_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LevelMgr _003C_003E4__this;

		private GameSPCtrl[] _003CtSpArray_003E5__2;

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
		public _003CInit_003Ed__38(int _003C_003E1__state)
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
	private sealed class _003CInitByConfig_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string pConfig;

		public LevelMgr _003C_003E4__this;

		private LevelConfig _003CtLevelConfig_003E5__2;

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
		public _003CInitByConfig_003Ed__37(int _003C_003E1__state)
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

	private static LevelMgr _Ins;

	[Header("镜头参数")]
	public CamInfoData CamInfo;

	[Header("棋盘尺寸: X行Y列 *须奇数列*")]
	public Vector2Int CellSize;

	[Header("选择管道: 管道名_出口数")]
	public PipeName CurPipe;

	[Header("管道模型**以下内容会自动设置无需关注**")]
	[Space]
	public GameObject PipMod;

	[Header("格子下的地面")]
	public GameObject GroundRoot;

	[Header("边界 左右上下")]
	public GameObject EdgeModL;

	public GameObject EdgeModR;

	public GameObject EdgeModU;

	public GameObject EdgeModD;

	public GameObject CamShadowMod;

	public BeadExit[] BeadExits;

	public TrackHolder[] Tracks;

	public WaitArea WaitA;

	public Transform CellRoot;

	public Transform BeadRoot;

	public Transform SpRoot;

	public List<NavCell> CellList;

	public List<BeadHolder> BeadHList;

	public int BeadIndex;

	public Dictionary<SpType, List<GameSPCtrl>> SpDic;

	public Vector2Int CurCap;

	public int BeadSum;

	public int BeadRemain;

	public List<ColorType> AppearColors;

	public int CostCoin;

	public int RevivalNum;

	public List<string> UsedTools;

	private List<SpType> m_CellRelateSpTypes;

	private SpType[] m_CheckSpStateTypes;

	public static LevelMgr Ins => null;

	public bool Ready { get; private set; }

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	[IteratorStateMachine(typeof(_003CInitByConfig_003Ed__37))]
	public IEnumerator InitByConfig(string pConfig)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CInit_003Ed__38))]
	public IEnumerator Init()
	{
		return null;
	}

	[ContextMenu("检测颜色数及容器颜色数")]
	private void CheckColorMatch()
	{
	}

	[ContextMenu("更正镜头")]
	private void SetCamera()
	{
	}

	[ContextMenu("生成管道")]
	private void InitPipMod()
	{
	}

	[ContextMenu("生成棋盘")]
	private void InitCells()
	{
	}

	[ContextMenu("更新棋盘墙壁")]
	private void UpdateCellWall()
	{
	}

	private void UpdateEdgeMod(bool pUpdateWalls)
	{
	}

	private void CreateWalls(int pRow, int pCol)
	{
	}

	[ContextMenu("生成球")]
	private void CreateBead()
	{
	}

	[ContextMenu("生成棋盘机制")]
	private void CreateSp()
	{
	}

	public NavCell GetCell(Vector2Int pPoint)
	{
		return null;
	}

	public NavCell GetCell(int pRow, int pCol)
	{
		return null;
	}

	public void ProcessUpdate()
	{
	}

	public bool CheckAllTrackFull()
	{
		return false;
	}

	public void CheckBeadPathEnable(bool pUpdatePos)
	{
	}

	[ContextMenu("**导出关卡配置**")]
	public void ExportConfig()
	{
	}
}
