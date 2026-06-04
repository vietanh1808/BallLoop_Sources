using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.Ads.FakeMediation
{
	internal abstract class FakeAd : MonoBehaviour
	{
		[SerializeField]
		private GameObject rootView;

		[SerializeField]
		[FormerlySerializedAs("_viewButton")]
		private Button viewButton;

		public Action onClick;

		protected void Awake()
		{
		}

		public void StartAd()
		{
		}

		public void StopAd()
		{
		}
	}
}
