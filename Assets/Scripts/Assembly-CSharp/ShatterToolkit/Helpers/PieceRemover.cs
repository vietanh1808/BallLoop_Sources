using UnityEngine;

namespace ShatterToolkit.Helpers
{
	[RequireComponent(typeof(ShatterTool))]
	public class PieceRemover : MonoBehaviour
	{
		public int startAtGeneration;

		public float timeDelay;

		public bool whenOutOfViewOnly;

		protected ShatterTool shatterTool;

		protected Renderer renderer;

		protected float timeSinceInstantiated;

		public void Start()
		{
		}

		public void Update()
		{
		}
	}
}
