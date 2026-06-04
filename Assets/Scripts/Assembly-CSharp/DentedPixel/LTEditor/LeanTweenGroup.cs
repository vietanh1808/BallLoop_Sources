using System;
using System.Collections.Generic;
using UnityEngine;

namespace DentedPixel.LTEditor
{
	[Serializable]
	public class LeanTweenGroup
	{
		public string name;

		public bool repeat;

		public float delay;

		public int repeatCount;

		public int repeatIter;

		public bool foldout;

		public GameObject gameObject;

		public GameObject overrideGameObject;

		public List<LeanTweenItem> itemList;

		private bool _generateCode;

		public float startTime => 0f;

		public float endTime => 0f;

		public bool generateCode => false;

		public LeanTweenGroup()
		{
		}

		public LeanTweenGroup(float delay)
		{
		}

		public LeanTweenGroup(LeanTweenGroup group)
		{
		}

		public void setGenerateCode()
		{
		}
	}
}
