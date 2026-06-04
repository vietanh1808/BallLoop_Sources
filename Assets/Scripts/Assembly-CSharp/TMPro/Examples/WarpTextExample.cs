using UnityEngine;

namespace TMPro.Examples
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(TMP_Text))]
	public class WarpTextExample : MonoBehaviour
	{
		private TMP_Text m_TextComponent;

		public AnimationCurve VertexCurve;

		public float AngleMultiplier;

		public float SpeedMultiplier;

		public float CurveScale;

		public float TextWidth;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		private void WarpText()
		{
		}
	}
}
