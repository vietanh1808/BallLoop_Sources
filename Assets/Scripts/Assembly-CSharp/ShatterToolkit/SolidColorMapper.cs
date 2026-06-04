using System.Collections.Generic;
using UnityEngine;

namespace ShatterToolkit
{
	public class SolidColorMapper : ColorMapper
	{
		public Color32 fillColor;

		public override void Map(IList<Vector3> points, Vector3 planeNormal, out Color32[] colorsA, out Color32[] colorsB)
		{
			colorsA = null;
			colorsB = null;
		}
	}
}
