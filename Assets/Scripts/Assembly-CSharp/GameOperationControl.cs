using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameOperationControl : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	public string SelfName;

	private int m_DragState;

	private bool m_Press;

	public Action<bool, PointerEventData> OnPressEvent;

	public Action<int, PointerEventData> OnDragEvent;

	public UnityEventDrag EventDrag;

	public UnityEventPress EventPress;

	public Image[] StateImage;

	public Sprite[] StateNormal;

	public Sprite[] StatePress;

	public int DragState => 0;

	public bool PressState => false;

	void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
	{
	}

	void IDragHandler.OnDrag(PointerEventData eventData)
	{
	}

	void IEndDragHandler.OnEndDrag(PointerEventData eventData)
	{
	}

	void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
	{
	}

	void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
	{
	}
}
