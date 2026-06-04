using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GamePathData
{
	public List<Vector3> CurPathVecs;

	public float[] LengthArray;

	public float CurLength;

	public float PathLength;

	public int CurIndex;

	public bool Loop;

	public bool NoSlope;

	private readonly float MinDis;

	public GamePathData()
	{
	}

	public GamePathData(Vector3[] pPoints)
	{
	}

	public GamePathData(List<Vector3> pPoints)
	{
	}

	public void Init(List<Vector3> pCurPath)
	{
	}

	public bool IsArriveEnd()
	{
		return false;
	}

	public void ResetAtStart()
	{
	}

	public Vector3 MoveBySpeed(float pSpeed, bool pCheckGround = false)
	{
		return default(Vector3);
	}

	public Vector3 GetPoint(float pDis)
	{
		return default(Vector3);
	}

	public Vector3 GetPointByPercent(float pPercent)
	{
		return default(Vector3);
	}
}
