using UnityEngine;
using UnityEngine.Events;

public class BeadTrigger : MonoBehaviour
{
	public UnityEvent<Collider> TriggerEvent;

	private void OnTriggerEnter(Collider other)
	{
	}
}
