using UnityEngine;

public class GameConfig : ScriptableObject
{
	private static GameConfig m_Instance;

	[Header("**UI通用置灰材质")]
	public Material UiGrayMat;

	[Header("**录视频关卡 0是不录")]
	public int VideoType;

	[Header("**录视频关卡5金币音效间隔")]
	public float VideoCoinSFXCool;

	[Header("**是否使用关卡配置文件")]
	public bool UseLevelConfig;

	[Header("**从第几关开始可以返回地图界面")]
	public int BackToMapLevel;

	[Header("**棋盘最小尺寸 超过此尺寸会有适配")]
	public Vector2Int BoardMinSize;

	[Header("**球大小")]
	public float BeadSize;

	[Header("**传送带长度 超过此距离容器不显示")]
	public float BeadHideDis;

	[Header("**球缩放 x是不能出 y是可以出 z是进管道 w是进容器")]
	public Vector4 BeadScale;

	[Header("**球移速 x出口-管道 y管道内 z管道->容器")]
	public Vector4 MoveSpeed;

	[Header("**地板大小")]
	public float CellSize;

	[Header("**球在格子内高度偏移")]
	public Vector3 BallOffset;

	[Header("**墙壁高度偏移")]
	public float WallH;

	[Header("**管道破碎参数 x是单个碎裂数 y是单个碎裂上限 z是每x个球一个破碎点")]
	public Vector3Int BreakValue;

	[Header("**开启入口进入管道")]
	public bool EnableEnterPip;

	[Header("**启用出口检测")]
	public bool EnableExit;

	[Header("**启用在管道内移动")]
	public bool EnableMoveInPip;

	[Header("**启用失败检测")]
	public bool EnableFailCheck;

	[Header("**球容器参数 x第二个盒子起点距离 y是第二个盒子之后的间隔 z是第二个及之后盒子宽度 ")]
	public Vector3 BoxPara;

	[Header("**盒子展示参数 x是抬高值 y是展示前等待 z是抬起时长 w是缩放时长 ")]
	public Vector4 BoxAnimPara;

	[Header("**操作面板依附底部的偏移")]
	public Vector3 OpeCtrlOffset;

	[Header("**道具依附底部的偏移")]
	public Vector3 ToolUiOffset;

	[Header("**相机相对底边位置偏移")]
	public Vector3 CamPosOffset;

	public bool CanReplaceMousePointer;

	public static GameConfig Instance => null;

	public void InitForRunning()
	{
	}
}
