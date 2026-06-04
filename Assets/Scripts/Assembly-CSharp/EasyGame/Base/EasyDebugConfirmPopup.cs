using System;
using TMPro;
using UnityEngine;

namespace EasyGame.Base
{
	public class EasyDebugConfirmPopup : MonoBehaviour
	{
		public TextMeshProUGUI TipsText;

		public Action<int> CloseStateAc;

		private int ClickResult;

		public static EasyDebugConfirmPopup ShowPop(string pTitleTxt = "Skip By Debug")
		{
			return null;
		}

		public static EasyDebugConfirmPopup ShowPop(Action<int> pResAc, string pTitleTxt = "Skip By Debug")
		{
			return null;
		}

		public void ClickBtnYes()
		{
		}

		public void ClickBtnNo()
		{
		}

		public void ClickBtnClose()
		{
		}

		public void DestroyPopup()
		{
		}
	}
}
