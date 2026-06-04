using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WaitArea : MonoBehaviour
{
	public static WaitArea Ins;

	[Header("进入主管道前的额外点")]
	public Transform[] EnterPoints;

	public List<BeadHolder> ToList;

	public List<BeadHolder> WaitList;

	public Vector2Int NavPos;

	public float EnterCool;

	public TextMeshPro NumText;

	public BeadHolder CurBead;

	public bool ShouldWaitEnter;

	public void Init()
	{
	}

	public void ProcessUpdate()
	{
	}

	public bool HaveWaitBead()
	{
		return false;
	}

	public void AddBead(BeadHolder pBead)
	{
	}

	public void RmBead(BeadHolder pBead)
	{
	}
}
