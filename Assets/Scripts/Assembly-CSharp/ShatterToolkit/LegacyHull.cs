using System.Collections.Generic;
using UnityEngine;

namespace ShatterToolkit
{
	public class LegacyHull : IHull
	{
		protected static float smallestValidLength;

		protected static float smallestValidRatio;

		protected Object key;

		protected IList<Vector3> vertices;

		protected IList<Vector3> normals;

		protected IList<Vector4> tangents;

		protected IList<Vector2> uvs;

		protected IList<Point> vertexToPointMap;

		protected IList<Point> points;

		protected IList<Edge> edges;

		protected IList<Triangle> triangles;

		public bool IsEmpty => false;

		public LegacyHull(Mesh mesh)
		{
		}

		public LegacyHull(LegacyHull reference)
		{
		}

		protected void AddUniquePoint(Vector3 position, out Point uniquePoint)
		{
			uniquePoint = null;
		}

		protected void AddUniqueEdge(Point point0, Point point1, out Edge uniqueEdge)
		{
			uniqueEdge = null;
		}

		protected void AddTriangle(int vertex0, int vertex1, int vertex2)
		{
		}

		protected void AddVertex(Vector3 vertex, Vector3 normal, Vector4 tangent, Vector2 uv, Point point, out int index)
		{
			index = default(int);
		}

		public void Clear()
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

		protected void SetIndices()
		{
		}

		protected void AssignPoints(LegacyHull a, LegacyHull b, Vector3 pointOnPlane, Vector3 planeNormal, out bool[] pointAbovePlane)
		{
			pointAbovePlane = null;
		}

		protected void AssignVertices(LegacyHull a, LegacyHull b, bool[] pointAbovePlane, out int[] oldToNewVertex)
		{
			oldToNewVertex = null;
		}

		protected void AssignEdges(LegacyHull a, LegacyHull b, bool[] pointAbovePlane, Vector3 pointOnPlane, Vector3 planeNormal, out bool[] edgeIntersectsPlane, out EdgeHit[] edgeHits)
		{
			edgeIntersectsPlane = null;
			edgeHits = null;
		}

		protected void AssignTriangles(LegacyHull a, LegacyHull b, bool[] pointAbovePlane, bool[] edgeIntersectsPlane, EdgeHit[] edgeHits, int[] oldToNewVertex, out IList<Edge> cutEdgesA, out IList<Edge> cutEdgesB)
		{
			cutEdgesA = null;
			cutEdgesB = null;
		}

		protected void SplitTriangle(LegacyHull topHull, LegacyHull bottomHull, Edge topEdge0, Edge topEdge1, Edge topCutEdge, Edge bottomEdge0, Edge bottomEdge1, Edge bottomCutEdge, Edge bottomEdge2, int vertex0, int vertex1, int vertex2, float scalar0, float scalar1, int[] oldToNewVertex)
		{
		}

		protected void SortCutEdges(IList<Edge> edgesA, IList<Edge> edgesB)
		{
		}

		protected void FillCutEdges(LegacyHull a, LegacyHull b, IList<Edge> edgesA, IList<Edge> edgesB, Vector3 planeNormal, UvMapper uvMapper)
		{
		}

		protected void ValidateOutput(LegacyHull a, LegacyHull b, Vector3 planeNormal)
		{
		}

		protected float LengthAlongAxis(Vector3 axis)
		{
			return 0f;
		}
	}
}
