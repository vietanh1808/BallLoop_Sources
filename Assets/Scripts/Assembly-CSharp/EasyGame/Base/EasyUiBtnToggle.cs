using UnityEngine;

namespace EasyGame.Base
{
	public class EasyUiBtnToggle : EasyUiBtn
	{
		public enum ToggleType
		{
			BgMusic = 0,
			Audio = 1,
			AllSound = 2,
			Haptic = 10
		}

		public ToggleType SelfType;

		public GameObject EnableUi;

		public GameObject DisableUi;

		public string ReportKey;

		public string ReportPara;

		public string[] ReportValue;

		[Header("滑块滑动效果")]
		public GameObject SlideUi;

		public Vector2 SlideVecX;

		private void Start()
		{
		}

		public override void OnBtnClickEvent()
		{
		}

		private void EnableAudio()
		{
		}

		private void SetUiStatus()
		{
		}

		private void SetSlideUiState(float pAnimTime = 0.3f)
		{
		}
	}
}
