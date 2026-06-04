using ShatterToolkit.Helpers;
using UnityEngine;

namespace ShatterToolkit.Examples
{
	[RequireComponent(typeof(MouseForce), typeof(MouseSplit), typeof(MouseShatter))]
	public class MouseGUI : MonoBehaviour
	{
		public int defaultSelection;

		protected MouseForce mouseForce;

		protected MouseSplit mouseSplit;

		protected MouseShatter mouseShatter;

		protected int toolbarSelection;

		protected string[] toolbarLabels;

		public void Awake()
		{
		}

		public void OnGUI()
		{
		}

		protected void SelectTool()
		{
		}
	}
}
