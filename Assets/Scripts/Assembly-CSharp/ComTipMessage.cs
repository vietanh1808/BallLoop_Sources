using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ComTipMessage : MonoBehaviour
{
	public CanvasGroup BgCanvas;

	public TextMeshProUGUI TipUiText;

	public RectTransform BgRectTrans;

	public Image IconImage;

	public Vector2 OffsetSizeVec;

	public static void Show(string pTxt, string pIcon = "", float pStartY = 550f)
	{
	}

	public void ShowMessage(string pTxt, string pIcon = "", float pStartY = 550f)
	{
	}
}
