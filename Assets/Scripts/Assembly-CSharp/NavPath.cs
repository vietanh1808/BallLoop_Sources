using System;
using System.Collections.Generic;
using UnityEngine;

public static class NavPath
{
	public static Action UpdatePathAc;

	public static Vector2Int CellSize;

	public static NavCell[,] CellArray;

	public static readonly (int dx, int dy)[] Directions;

	public static void Init(int pRow, int pCol)
	{
	}

	public static NavCell GetCell(Vector2Int pPos)
	{
		return null;
	}

	public static List<Vector2Int> FindPath(Vector2Int pStartPos, Vector2Int pEndPos, BeadHolder pItem)
	{
		return null;
	}

	private static List<Vector2Int> ReconstructPath(Dictionary<Vector2Int, Vector2Int> pCameFrom, Vector2Int pCurrent)
	{
		return null;
	}

	private static List<Vector2Int> GetNeighbors(Vector2Int pos)
	{
		return null;
	}

	public static bool IsValidPosition(Vector2Int pos)
	{
		return false;
	}

	private static float Heuristic(Vector2Int a, Vector2Int b)
	{
		return 0f;
	}

	public static List<BeadHolder> GetConnectedBoxs(List<BeadHolder> pAllBlocks, BeadHolder pItem)
	{
		return null;
	}

	private static void FindConnectedRegion(BeadHolder start, HashSet<BeadHolder> allPoints, HashSet<BeadHolder> visited, List<BeadHolder> region)
	{
	}
}
