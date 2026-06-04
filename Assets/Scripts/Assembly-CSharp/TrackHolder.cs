using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GamePathHolder))]
public class TrackHolder : MonoBehaviour
{
	[Header("当前路径最大容量")]
	public int MaxNum;

	[Header("最大容量+X针对某些关")]
	public int ExtraNum;

	public int Index;

	public GamePathHolder SelfPath;

	public List<BeadHolder> InList;

	public List<BeadHolder> OutList;

	public float BeadSpace;

	public bool ShouldWaitEnter;

	public void Init()
	{
	}

	public void ProcessUpdate(int pIndex, int pMax)
	{
	}

	public void AddInBead(BeadHolder pBead)
	{
	}

	public void RmInBead(BeadHolder pBead)
	{
	}

	public void AddOutBead(BeadHolder pBead)
	{
	}

	public void RmOutBead(BeadHolder pBead)
	{
	}
}
