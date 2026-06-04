using System.Collections.Generic;
using UnityEngine;

namespace ShatterToolkit
{
	public class Triangulator : ITriangulator
	{
		protected List<Vector3> points;

		protected List<int> edges;

		protected List<int> triangles;

		protected List<int> triangleEdges;

		protected List<List<int>> loops;

		protected List<List<bool>> concavities;

		protected List<int> duplicateEdges;

		protected Vector3 planeNormal;

		protected int originalEdgeCount;

		public Triangulator(IList<Vector3> points, IList<int> edges, Vector3 planeNormal)
		{
		}

		public void Fill(out int[] newEdges, out int[] newTriangles, out int[] newTriangleEdges)
		{
			newEdges = null;
			newTriangles = null;
			newTriangleEdges = null;
		}

		protected void FindLoops()
		{
		}

		protected void FindConcavities()
		{
		}

		protected void PrepareDuplicateEdges()
		{
		}

		protected void ValidateConcavities()
		{
		}

		protected void UpdateConcavity(int index, List<int> loop, List<bool> concavity)
		{
		}

		protected bool IsLinePairConcave(ref Vector3 line0, ref Vector3 line1)
		{
			return false;
		}

		protected bool IsTriangleOverlappingLoop(int first, int second, int third, List<int> loop, List<bool> concavity)
		{
			return false;
		}

		protected bool MergeLoops(int first, int second, int third, List<int> loop, List<bool> concavity, out int swallowedLoopIndex)
		{
			swallowedLoopIndex = default(int);
			return false;
		}

		protected bool FindClosestPointInTriangle(int first, int second, int third, List<int> loop, out int loopIndex, out int loopLocation)
		{
			loopIndex = default(int);
			loopLocation = default(int);
			return false;
		}

		protected void InsertLoop(int insertLocation, List<int> loop, List<bool> concavity, int otherAnchorLocation, List<int> otherLoop, List<bool> otherConcavity)
		{
		}

		protected void FillTriangle(int zero, int first, int second, int third, List<int> loop, List<bool> concavity)
		{
		}

		protected void RemoveDuplicateEdges()
		{
		}

		protected void SetOutput(out int[] newEdges, out int[] newTriangles, out int[] newTriangleEdges)
		{
			newEdges = null;
			newTriangles = null;
			newTriangleEdges = null;
		}
	}
}
