using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
public class GameSP_TanChuPingTaiCell : MonoBehaviour
{
	[Header("此格子要生成球的颜色和数量")]
	public List<ColorNumPara> ColorParas;

	[Space]
	[Header("以下为自动生成数据 无需理会")]
	public Vector2Int Point;

	public int Index;

	public bool IsWall;

	public Vector2Int RelateNavCellPoint;

	public GameSP_TanChuPingTaiPanel RootPanel;

	public GameObject CellMod;

	public GameObject WallMod;

	public List<BeadHolder> BHList;

	public GameObject EffectMod;

	public void Init()
	{
	}

	public void UpdateGround()
	{
	}
}
