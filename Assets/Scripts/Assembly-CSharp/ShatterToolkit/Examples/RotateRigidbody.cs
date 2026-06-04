using UnityEngine;

namespace ShatterToolkit.Examples
{
	[RequireComponent(typeof(Rigidbody))]
	public class RotateRigidbody : MonoBehaviour
	{
		public Vector3 axis;

		public float angularVelocity;

		protected Rigidbody rb;

		public void Start()
		{
		}

		public void FixedUpdate()
		{
		}
	}
}
