using System;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
public class BeadExit : MonoBehaviour
{
	[Serializable]
	public class ExitSp
	{
		[Header("*必填*特殊机制类型")]
		public SpType Type;

		[Range(0f, 999f)]
		[Header("需要完成的目标数")]
		public int GoalNum;
	}

	[Header("*必填*容器颜色和容量**填完后注意点击生成容器**")]
	public List<BoxCapData> CapList;

	[Header("机制数据*注意Box开头的为球机制*")]
	public List<ExitSp> SpList;

	[Space]
	[Header("**以下内容会自动设置无需关注**")]
	public GamePathHolder MoveInPath;

	public GamePathHolder BoxQuePath;

	public List<BeadBox> BoxList;

	public int State;

	public Renderer TransportR;

	public Material TransportMat;

	public Transform TransportRoot;

	public BeadTrigger PickTrigger;

	public Dictionary<SpType, SpData> SpDic;

	public Dictionary<SpType, GameSPCtrl> SpCtrlDic;

	private static float m_OutAudioTime;

	public void Init()
	{
	}

	[ContextMenu("解析容器数据")]
	private void InitBoxByStr()
	{
	}

	[ContextMenu("生成容器")]
	public void InitBoxData()
	{
	}

	[ContextMenu("生成或校正机制")]
	public void CorrectData()
	{
	}

	private void CreateSpSaiZi(ExitSp pSp)
	{
	}

	public void ProcessPickBead(Collider pBead)
	{
	}

	private void PlayOutAudio()
	{
	}

	public void ProcessFinishBox(BeadBox pBox)
	{
	}

	public bool UpdateBoxPos(float pStartLength = 0f, float pAnimTime = 0.2f)
	{
		return false;
	}

	private void ForceSetBoxPos()
	{
	}
}
