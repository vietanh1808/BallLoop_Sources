using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace EasyGame.Base
{
	public class EasyUiBtn : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler
	{
		[CompilerGenerated]
		private sealed class _003CProcessLoopTap_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EasyUiBtn _003C_003E4__this;

			private float _003CtTime_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CProcessLoopTap_003Ed__34(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Header("是否在测试键开启时才展示")]
		public bool EnableByDebugMode;

		[Header("展示或隐藏的节点")]
		public GameObject[] TargetRoots;

		public Action ClickAc;

		public Action<EasyUiBtn> ClickWithBtnAc;

		public bool ClickEnable;

		public bool TriggerUnityEvent;

		public UnityEvent UnityEvent;

		public bool TriggerClickAction;

		public string BtnName;

		[Header("点击大小缩放")]
		public bool EnableScale;

		public Vector3 ToScale;

		public Vector3 FromScale;

		[Header("点击时候播放音效")]
		public bool PlayAudio;

		public bool IsOverrideAudio;

		public string AudioName;

		[Header("点击后展示的弹窗路径")]
		public string PopupName;

		[Header("弹窗是否无父级")]
		public bool NoParent;

		[Header("点击冷却时间")]
		public float ClickInterval;

		private float ClickTimer;

		[Header("激活连续点击")]
		public bool EnableLoop;

		private bool m_Press;

		private float m_LoopTimer;

		[Header("是否忽略时间缩放")]
		public bool UseUnscaleTime;

		private void Awake()
		{
		}

		protected virtual void ProcessAwake()
		{
		}

		private void OnDestroy()
		{
		}

		protected virtual void ProcessDestroy()
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		public virtual void OnButtonClick()
		{
		}

		public virtual void ShowPopup()
		{
		}

		public virtual void OnBtnClickEvent()
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}

		public virtual void OnBtnPressEvent(bool pDown, PointerEventData pData)
		{
		}

		[IteratorStateMachine(typeof(_003CProcessLoopTap_003Ed__34))]
		private IEnumerator ProcessLoopTap()
		{
			return null;
		}
	}
}
