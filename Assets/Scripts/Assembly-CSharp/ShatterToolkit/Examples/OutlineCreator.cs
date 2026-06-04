using System.Collections.Generic;
using UnityEngine;

namespace ShatterToolkit.Examples
{
	public class OutlineCreator : MonoBehaviour
	{
		protected List<Vector3> points;

		protected List<int> edges;

		protected List<int> triangles;

		protected List<int> triangleEdges;

		protected bool isTriangulated;

		protected bool isLoopClosed;

		protected int loopStart;

		public int LoopPointCount => 0;

		public void Reset()
		{
		}

		public void Update()
		{
		}

		public void OnGUI()
		{
		}

		public void OnDrawGizmos()
		{
		}
	}
}
