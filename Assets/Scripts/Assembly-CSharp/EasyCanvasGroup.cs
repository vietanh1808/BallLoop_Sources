using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class EasyCanvasGroup : MonoBehaviour
{
	public string SelfName;

	public string SelfGroup;

	public CanvasGroup SelfCanvas;

	public GameObject AnimRoot;

	[Header("控制透明度")]
	public bool EnableAlpha;

	[Header("控制透明度")]
	public bool EnableMove;

	[Header("控制透明度")]
	public bool EnableScale;

	public Vector3 ShowPos;

	public Vector3 HidePos;

	public LeanTweenType ShowEase;

	public LeanTweenType HideEase;

	public float ShowScale;

	public float HideScale;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private bool ShouldPlayAnim(EasyCanvasAnim pAnim)
	{
		return false;
	}

	public void OnAlphaEvent(EasyCanvasAnim pAnim)
	{
	}

	private void ProcessAlphaAnim(bool pShow, float pTime, float pDelay)
	{
	}

	public void OnMoveEvent(EasyCanvasAnim pAnim)
	{
	}

	private void ProcessMoveAnim(bool pShow, float pTime, float pDelay)
	{
	}

	public void OnScaleEvent(EasyCanvasAnim pAnim)
	{
	}

	private void ProcessScaleAnim(bool pShow, float pTime, float pDelay)
	{
	}
}
