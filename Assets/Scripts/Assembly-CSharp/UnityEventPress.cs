using System;
using UnityEngine.EventSystems;
using UnityEngine.Events;

[Serializable]
public class UnityEventPress : UnityEvent<string, bool, PointerEventData>
{
}
