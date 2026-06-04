using UnityEngine;

[RequireComponent(typeof(Canvas))]
public class EasyCanvasSet : MonoBehaviour
{
	[Header("将Canvas指向新相机后,原相机是否不再启用")]
	public bool DisableOldCam;

	private void Start()
	{
	}
}
