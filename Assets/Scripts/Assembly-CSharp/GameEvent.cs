using System;
using UnityEngine;

public class GameEvent
{
	public static Action<BeadHolder> BeadInWaitAc;

	public static Action BeadTapAc;

	public static Action<BeadBox> BoxFinishAc;

	public static Action UpdateSpAc;

	public static Action<SceneId> SceneLoadAc;

	public static Action<Vector4> CameraShakeAc;

	public static Action<SpecialBtnId> SpBtnClickByIdAc;

	public static Action<GameSpecialBtnView> SpBtnClickByBtnAc;

	public static Action<string, int, int> ExpLvChangeEffectAc;

	public static Action<string, int, int> ExpLvChangeValueAc;

	public static bool UiTouchEnable;

	public const string Key_Ui_BtnClick = "GameUiBtnClick";

	public const string Key_Ui_BtnPress = "GameUiBtnPress";

	public const string Key_UiCanvas_Alpha = "GameUiCanvasAlpha";

	public const string Key_UiCanvas_Move = "GameUiCanvasMove";

	public const string Key_UiCanvas_Scale = "GameUiCanvasScale";

	public const string Key_AssetChange = "GameAssetChange";

	public const string Key_AssetBarAdd = "GameAssetBarAdd";

	public const string Key_AssetBarReset = "GameAssetBarReset";

	public const string Key_PowerChange = "GamePowerChange";

	public const string Key_PowerBarAdd = "GamePowerBarAdd";

	public const string Key_UiLayerSet = "GameUiLayerSet";
}
