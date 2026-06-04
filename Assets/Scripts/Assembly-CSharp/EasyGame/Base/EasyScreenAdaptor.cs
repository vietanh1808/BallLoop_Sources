using System;
using UnityEngine;

namespace EasyGame.Base
{
	[ExecuteInEditMode]
	public class EasyScreenAdaptor : MonoBehaviour
	{
		[Flags]
		public enum FitMode
		{
			Left = 1,
			Right = 2,
			Top = 4,
			Bottom = 8,
			All = 0xF
		}

		private RectTransform selfPanel;

		private Rect LastSafeArea;

		private Rect[] NSA_iPhoneX;

		private const float SAFE_AREA_ASPECT = 1.7977529f;

		[SerializeField]
		private FitMode _fitMode;

		private bool _alreadyRefreshed;

		private Vector2 _originalAnchorMin;

		private Vector2 _originalAnchorMax;

		private Rect lastRect;

		private RectTransform Panel => null;

		private void Start()
		{
		}

		private void Refresh()
		{
		}

		private Rect GetSafeArea()
		{
			return default(Rect);
		}

		private void ApplySafeArea(Rect r)
		{
		}

		public bool MatchFitMode(FitMode fitMode)
		{
			return false;
		}
	}
}
