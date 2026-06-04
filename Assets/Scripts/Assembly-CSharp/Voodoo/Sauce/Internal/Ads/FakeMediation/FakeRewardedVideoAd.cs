using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Voodoo.Sauce.Internal.Ads.FakeMediation
{
	internal class FakeRewardedVideoAd : FakeClosableAd
	{
		[SerializeField]
		[FormerlySerializedAs("_closeWithRewardButton")]
		private Button closeWithRewardButton;

		[FormerlySerializedAs("_closeWithoutRewardButton")]
		[SerializeField]
		private Button closeWithoutRewardButton;

		public Action onCloseWithReward;

		public Action onCloseWithoutReward;

		protected new void Awake()
		{
		}
	}
}
