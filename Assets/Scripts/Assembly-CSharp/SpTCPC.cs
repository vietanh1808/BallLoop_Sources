using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SpTCPC
{
	[Header("关联格子坐标 x:行 y:列")]
	public NavVec2 Point;

	[Header("球颜色和数量")]
	public List<ColorNumPara> CNP;
}
