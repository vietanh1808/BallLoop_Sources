using System.Collections.Generic;
using UnityEngine;

namespace ShatterToolkit
{
	public class TargetUvMapper : UvMapper
	{
		public Vector2 targetStart;

		public Vector2 targetSize;

		public bool square;

		public bool centerMeshOrigo;

		public override void Map(IList<Vector3> points, Vector3 planeNormal, out Vector4[] tangentsA, out Vector4[] tangentsB, out Vector2[] uvsA, out Vector2[] uvsB)
		{
			tangentsA = null;
			tangentsB = null;
			uvsA = null;
			uvsB = null;
		}
	}
}
