using UnityEngine;

namespace ShatterToolkit.Helpers
{
	[RequireComponent(typeof(ShatterTool))]
	public class HierarchyHandler : MonoBehaviour
	{
		public bool attachPieceToParent;

		public float maxPieceToParentDistance;

		public bool addRbToDetachedPieces;

		public bool attachChildrenToPieces;

		public float maxChildToPieceDistance;

		public bool addRbToDetachedChildren;

		protected Transform parent;

		protected Transform[] children;

		public void PreSplit(Plane[] planes)
		{
		}

		public void PostSplit(GameObject[] newGameObjects)
		{
		}

		protected ShatterTool FindClosestPiece(ShatterTool reference, ShatterTool[] pieces, float maxDistance)
		{
			return null;
		}
	}
}
