using UnityEngine;

[RequireComponent(typeof(Canvas))]
public class EasyUiLayer : MonoBehaviour
{
	public string UnqueId;

	public string GroupId;

	public Canvas SelfCanvas;

	public int OldLayer;

	public int OffsetLayer;

	public int LayerChangeCount;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void OnLayerSetEvent(string pGroup, string pName, int pLayer)
	{
	}
}
