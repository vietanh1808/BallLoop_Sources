using System.Collections.Generic;
using UnityEngine;

namespace ShatterToolkit
{
	public class FastHull : IHull
	{
		protected static float smallestValidLength;

		protected static float smallestValidRatio;

		protected bool isValid;

		protected List<Vector3> vertices;

		protected List<Vector3> normals;

		protected List<Color32> colors;

		protected List<Vector4> tangents;

		protected List<Vector2> uvs;

		protected List<int> indices;

		public bool IsEmpty => false;

		public FastHull(Mesh mesh)
		{
		}

		public FastHull(FastHull reference)
		{
		}

		public Mesh GetMesh()
		{
			return null;
		}

		public void Split(Vector3 localPointOnPlane, Vector3 localPlaneNormal, bool fillCut, UvMapper uvMapper, ColorMapper colorMapper, out IHull resultA, out IHull resultB)
		{
			resultA = null;
			resultB = null;
		}

		protected void AssignVertices(FastHull a, FastHull b, Vector3 pointOnPlane, Vector3 planeNormal, out bool[] vertexAbovePlane, out int[] oldToNewVertexMap)
		{
			vertexAbovePlane = null;
			oldToNewVertexMap = null;
		}

		protected void AssignTriangles(FastHull a, FastHull b, bool[] vertexAbovePlane, int[] oldToNewVertexMap, Vector3 pointOnPlane, Vector3 planeNormal, out IList<Vector3> cutEdges)
		{
			cutEdges = null;
		}

		protected void SplitTriangle(FastHull topHull, FastHull bottomHull, int[] oldToNewVertexMap, Vector3 pointOnPlane, Vector3 planeNormal, int top, int cw, int ccw, out Vector3 cwIntersection, out Vector3 ccwIntersection)
		{
			cwIntersection = default(Vector3);
			ccwIntersection = default(Vector3);
		}

		protected void FillCutEdges(FastHull a, FastHull b, IList<Vector3> edges, Vector3 planeNormal, UvMapper uvMapper, ColorMapper colorMapper)
		{
		}

		protected void ValidateOutput(FastHull a, FastHull b, Vector3 planeNormal)
		{
		}

		protected float LengthAlongAxis(Vector3 axis)
		{
			return 0f;
		}
	}
}
