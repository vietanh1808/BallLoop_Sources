using System;
using UnityEngine;

namespace DentedPixel.LTEditor
{
	[Serializable]
	public class LeanTweenItem
	{
		public string name;

		public GameObject gameObject;

		public TweenAction action;

		public int actionLast;

		public string actionStr;

		public LeanTweenBetween between;

		public LeanTweenType ease;

		public string easeStr;

		public AnimationCurve animationCurve;

		public Vector3 from;

		public Vector3 to;

		public Color colorTo;

		public Vector3 axis;

		public float duration;

		public float delay;

		public float speed;

		public bool useSpeed;

		public bool alignWithPrevious;

		public bool foldout;

		public LeanTweenPath bezierPath;

		public LeanTweenPath splinePath;

		public AudioClip audioClip;

		public bool orientToPath;

		public bool isPath2d;

		public bool doesLoop;

		public int loopCount;

		public LeanTweenType loopType;

		public Sprite[] sprites;

		public bool spritesMaximized;

		public float frameRate;

		public LeanTweenItem()
		{
		}

		public LeanTweenItem(float delay)
		{
		}

		public LeanTweenItem(LeanTweenItem item)
		{
		}
	}
}
