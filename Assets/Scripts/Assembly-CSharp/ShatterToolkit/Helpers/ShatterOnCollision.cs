using UnityEngine;

namespace ShatterToolkit.Helpers
{
	public class ShatterOnCollision : MonoBehaviour
	{
		public float requiredVelocity;

		public float cooldownTime;

		protected float timeSinceInstantiated;

		public void Update()
		{
		}

		public void OnCollisionEnter(Collision collision)
		{
		}
	}
}
