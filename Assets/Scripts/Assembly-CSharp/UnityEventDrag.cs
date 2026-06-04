using System;
using UnityEngine.EventSystems;
using UnityEngine.Events;

[Serializable]
public class UnityEventDrag : UnityEvent<string, int, PointerEventData>
{
}
