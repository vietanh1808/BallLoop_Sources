using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
public class NavCell : MonoBehaviour
{
	[Space]
	[Header("格子寻路标记用 *以下属性自动设置无需理会*")]
	public string TypeStr;

	public bool IsWall;

	public BeadHolder SelfBead;

	private bool m_IsBusy;

	public Vector2Int Point;

	public Vector2Int NavSize;

	public int SelfIndex;

	public GameObject EmptyMod;

	public GameObject WallMod;

	public GameObject WallRoot;

	public Renderer GroundR;

	public static List<Vector2Int> MaiChongZhaMenPoints;

	public void Init(Vector2Int pPoint, Vector2Int pNavSize)
	{
	}

	public void SetType(string pType)
	{
	}

	public bool IsWalkable(BeadHolder pItem)
	{
		return false;
	}

	public bool CanCreateBead()
	{
		return false;
	}

	[ContextMenu("设置为墙壁")]
	private void SetAsWall()
	{
	}

	[ContextMenu("设置为空格")]
	private void SetAsEmpty()
	{
	}

	private void UpdateWallState()
	{
	}

	public void SetBusyState(bool pBusy)
	{
	}

	public bool IsBusy()
	{
		return false;
	}

	[ContextMenu("在本格子生成球")]
	private void CreateBead()
	{
	}

	[ContextMenu("在本格子生成机制")]
	private void CreateSp()
	{
	}

	public void UpdateState()
	{
	}

	public Vector3 GetBeadPos()
	{
		return default(Vector3);
	}

	public Vector3 GetCenterUpPos()
	{
		return default(Vector3);
	}

	public void SetVisible(bool pVisible)
	{
	}
}
