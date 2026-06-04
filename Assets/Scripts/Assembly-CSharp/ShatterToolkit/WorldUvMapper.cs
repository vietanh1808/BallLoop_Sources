using System.Collections.Generic;
using UnityEngine;

namespace ShatterToolkit
{
	public class WorldUvMapper : UvMapper
	{
		public Vector2 scale;

		public override void Map(IList<Vector3> points, Vector3 planeNormal, out Vector4[] tangentsA, out Vector4[] tangentsB, out Vector2[] uvsA, out Vector2[] uvsB)
		{
			tangentsA = null;
			tangentsB = null;
			uvsA = null;
			uvsB = null;
		}
	}
}
