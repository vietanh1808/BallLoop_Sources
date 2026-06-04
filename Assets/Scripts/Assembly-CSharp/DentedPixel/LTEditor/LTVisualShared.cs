using UnityEngine;

namespace DentedPixel.LTEditor
{
	public class LTVisualShared : MonoBehaviour
	{
		public static string[] LT_2_12_MethodNames;

		public static object[][] methodLabelsGrouping;

		public static string[] methodLabels;

		public static string[] methodStrMapping;

		public static int[] methodIntMapping;

		public static string[] methodStrMappingGrouping;

		public static int[] methodIntMappingGrouping;

		public static int[] easeIntMapping;

		public static string[] easeStrMapping;

		public static void updateTweens(LeanTweenVisual tween)
		{
		}

		public static int actionIndex(LeanTweenItem item)
		{
			return 0;
		}

		public static void setActionIndex(LeanTweenItem item, int newIndex)
		{
		}

		public static int easeIndex(LeanTweenItem item)
		{
			return 0;
		}

		public static void setEaseIndex(LeanTweenItem item, int newIndex)
		{
		}
	}
}
