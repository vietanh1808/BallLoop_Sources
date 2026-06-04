using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace DentedPixel.LTEditor
{
	[AddComponentMenu("LeanTween/LeanTweenVisual")]
	public class LeanTweenVisual : MonoBehaviour
	{
		public List<LeanTweenGroup> groupList;

		public bool repeat;

		public float repeatDelay;

		public int repeatCount;

		public int repeatIter;

		public float nextCall;

		public bool restartOnEnable;

		public bool playOnStart;

		public int versionNum;

		private StringBuilder codeBuild;

		private string tabs;

		private LTDescr tween;

		private float allTweensDelaySaved;

		private bool _isBuilded;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void start(GameObject target = null)
		{
		}

		private void Update()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public void CopyTo(LeanTweenVisual tween)
		{
		}

		public void buildAllTweensAgain()
		{
		}

		public void buildAllTweensAgainNow()
		{
		}

		public LTDescr append(string method, float to, float duration)
		{
			return null;
		}

		public LTDescr appendRect(string method, float to, float duration)
		{
			return null;
		}

		public LTDescr append(string method, Vector3 to, float duration)
		{
			return null;
		}

		public LTDescr appendRect(string method, Vector3 to, float duration)
		{
			return null;
		}

		public LTDescr appendRect(string method, Vector2 to, float duration)
		{
			return null;
		}

		public LTDescr appendRect(string method, Color color, float duration)
		{
			return null;
		}

		public LTDescr append(string method, Color color, float duration)
		{
			return null;
		}

		public LTDescr append(string method, Vector3[] to, float duration)
		{
			return null;
		}

		public void append(AnimationCurve curve)
		{
		}

		private string vecToStr(Vector3 vec3)
		{
			return null;
		}

		private string vecToStr(Vector2 vec2)
		{
			return null;
		}

		private string colorToStr(Color color)
		{
			return null;
		}

		private void buildTween(LeanTweenItem item, float delayAdd, bool generateCode)
		{
		}

		public void buildGroup(object g)
		{
		}

		public string buildAllTweens(bool generateCode, GameObject overrideGameObject = null)
		{
			return null;
		}
	}
}
