using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class CustomMousePointer : MonoBehaviour
{
	[Header("指针设置")]
	public Sprite cursorSprite;

	public Texture2D cursorTexture;

	public Vector2 hotSpot;

	[Header("动画设置")]
	public Sprite[] clickAnimationFrames;

	public float animationFps;

	private Image m_PointerImage;

	private bool m_IsAnimating;

	private float m_AnimationTimer;

	private int m_CurrentFrame;

	private bool m_IsUsingCustomCursor;

	private Canvas m_ParentCanvas;

	private EventSystem m_EventSystem;

	private PointerEventData m_PointerEventData;

	private GameObject m_LastSelectedObject;

	private List<RaycastResult> m_RaycastResults;

	private bool m_Press;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void CheckMouseInGameWindow()
	{
	}

	private void UpdateCursorVisibility()
	{
	}

	private void FollowMousePosition()
	{
	}

	private void HandleMouseInput()
	{
	}

	private void HandleHoverState()
	{
	}

	private void HandlePointerDown()
	{
	}

	private void HandlePointerUp()
	{
	}

	private void PlayClickAnimation()
	{
	}

	private void OnDestroy()
	{
	}
}
