using System;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
public class BeadHolder : MonoBehaviour
{
	[Serializable]
	public class BeadSp
	{
		[Header("*必填*特殊机制类型")]
		public SpType Type;

		[Range(0f, 999f)]
		[Header("需要完成的目标数")]
		public int GoalNum;

		[Header("特殊机制同类型下的分组")]
		[Tooltip("例如钥匙要区分不同颜色的钥匙和锁\n又例如多个断裂路段需要区分不同的路段和铲子")]
		public string Group;
	}

	public enum BeadState
	{
		None = 0,
		Out = 1,
		ToWaitArea = 2,
		WaitToPip = 3,
		ToPip = 9,
		InPip = 10,
		ToExit = 20,
		Finish = 30
	}

	[Header("*必填*颜色")]
	public ColorType SelfColor;

	[Header("机制数据*注意Bead开头的为球机制*")]
	public List<BeadSp> SpList;

	[Space(10f)]
	[Header("以下内容会自动设置无需关注")]
	public Animator SelfAnim;

	public Renderer[] BodyRs;

	public Renderer OutlineR;

	public GameObject ToolSelectMod;

	public GameObject ShadwMod;

	public Rigidbody Rb;

	public Collider SelfCol;

	public BeadState CurState;

	public int Group;

	public float PathDis;

	public float LimitDis;

	public BeadBox ToBox;

	public GamePathData SelfPath;

	public TrackHolder InTrack;

	public Vector2Int Point;

	public List<Vector2Int> OutPathList;

	public List<BeadHolder> ConnectList;

	public float DelayTime;

	public Dictionary<SpType, GameSPCtrl> SpCtrlDic;

	public float InPipSpeedFactor;

	private BoxCollider TapBoxCol;

	private static float m_ShakeTimer;

	public void Init(ColorType pColor)
	{
	}

	public void SetRelateCellType()
	{
	}

	[ContextMenu("校正数据和生成机制*需先填写数据*")]
	public void CorrectData()
	{
	}

	private void CreateMangQiu(BeadSp pSp)
	{
	}

	private void CreateBingQiu(BeadSp pSp)
	{
	}

	private void CreateDuanLieLuDuan(BeadSp pSp)
	{
	}

	private void CreateMiFengRongQi(BeadSp pSp)
	{
	}

	private void CreateYinNiXiaoQiu(BeadSp pSp)
	{
	}

	private void CreateYinLi(BeadSp pSp)
	{
	}

	public void ProcessUpdate()
	{
	}

	private void PlayInBoxFx()
	{
	}

	public void SetOutPathState(List<Vector2Int> pList)
	{
	}

	public void ForceFinishSp(SpType pType)
	{
	}

	public void TriggerSp()
	{
	}

	public void PlayShakeAnim()
	{
	}

	public bool CanMove()
	{
		return false;
	}

	public void FailFlash()
	{
	}

	public void LeaveCell()
	{
	}
}
