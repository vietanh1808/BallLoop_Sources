using System;
using UnityEngine;

[Serializable]
public class ColorNumPara
{
	public ColorType Color;

	[Range(0f, 999f)]
	public int Num;
}
