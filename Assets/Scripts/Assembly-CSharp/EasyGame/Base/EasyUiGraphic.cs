using UnityEngine;
using UnityEngine.UI;

namespace EasyGame.Base
{
	[RequireComponent(typeof(CanvasRenderer))]
	public class EasyUiGraphic : MaskableGraphic
	{
		protected EasyUiGraphic()
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}
	}
}
