using UnityEngine;

[ExecuteInEditMode]
public class EasyRectTransAdjust : MonoBehaviour
{
	public enum AdjustAxis
	{
		None = 0,
		Width = 1,
		Height = 2,
		All = 100
	}

	[Header("目标物体")]
	public RectTransform TartgetRect;

	[Header("来源物体")]
	public RectTransform FromRect;

	[Header("适配的轴向类型")]
	public AdjustAxis AdjustType;

	public Vector2 SizeOffset;

	[Header("目标尺寸X范围")]
	public Vector2 SizeLimitX;

	[Header("目标尺寸Y范围")]
	public Vector2 SizeLimitY;

	private void OnRectTransformDimensionsChange()
	{
	}
}
