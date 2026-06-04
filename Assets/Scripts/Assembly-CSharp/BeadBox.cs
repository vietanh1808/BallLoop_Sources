using System;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
public class BeadBox : MonoBehaviour
{
	[Serializable]
	public class BoxSp
	{
		[Header("*必填*特殊机制类型")]
		public SpType Type;

		[Header("需要完成的目标数")]
		[Range(0f, 999f)]
		public int GoalNum;
	}

	[Header("机制数据*注意Box开头的为球机制*")]
	public List<BoxSp> SpList;

	[Header("以下内容会自动设置无需关注")]
	[Space]
	public float Length;

	public Renderer BodyR;

	public Transform[] BeadPoints;

	public MaterialPropertyBlock MPB;

	public int TargetNum;

	public List<ColorType> ColorList;

	public List<ColorType> RecColors;

	public List<BeadHolder> BeadHList;

	public BeadExit RootExit;

	public float CurDis;

	public bool ShouldWork;

	public SkinnedMeshRenderer[] CoverSmrs;

	public float CoverOldY;

	public Dictionary<SpType, GameSPCtrl> SpCtrlDic;

	public void Init(ColorType pStr, int pNum, bool pForEdit = false)
	{
	}

	[ContextMenu("校正数据和生成机制")]
	public void CorrectData()
	{
	}

	private void CreateSpMang(BoxSp pSp)
	{
	}

	public void CheckSpMang(int pIndex)
	{
	}

	private void CreateSpMiFengRongQi(BoxSp pSp)
	{
	}

	public void UpdateMatHide(float tDis)
	{
	}

	public void ShowBox(bool pShowAnim = true)
	{
	}

	public void HideBox()
	{
	}

	public void CheckFinish()
	{
	}

	public void AddBead(BeadHolder pBead)
	{
	}

	public Vector3 GetBeadPoint(int pIndex)
	{
		return default(Vector3);
	}
}
