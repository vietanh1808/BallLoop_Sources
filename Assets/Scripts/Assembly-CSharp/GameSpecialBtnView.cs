using EasyGame.Base;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameSpecialBtnView : EasyUiBtn
{
	[Header("特殊按钮的Id")]
	public SpecialBtnId SpBtnId;

	public RectTransform SelfRect;

	private Vector2 OldRectSize;

	[Header("子物体节点，控制部分动画效果或者位移")]
	public GameObject MoveRoot;

	[Header("功能未激活时的锁")]
	public GameObject LockUi;

	public float SpeBtnTimer;

	public float RefreshDuration;

	[Header("是否根据时间自动出现")]
	public bool AutoAppear;

	[Header("自动出现的时间间隔，随机范围")]
	public Vector3 AppearRang;

	[Header("游戏开始时的隐藏时间")]
	public Vector3 HideRangAtStart;

	[Header("出现后持续时间")]
	public float AppearExistTime;

	[Header("持续倒计时ui")]
	public GameObject ExistTimeRoot;

	public TextMeshProUGUI ExistTimeText;

	[Header("每日刷新 是否更新红点")]
	public bool UpdateRedPoUi;

	public GameObject RedPoint;

	[Header("每日刷新 是否检查")]
	public bool CheckDailyTime;

	public TextMeshProUGUI DailyNumText;

	[Header("每日刷新 是否清除进度")]
	public bool ClearWorkTime;

	[Header("每日启动自动弹窗")]
	public bool AutoDailyPopup;

	public bool AutoShowed;

	[Header("每日显示隐藏按钮")]
	public bool SetBtnDailyVisible;

	[Header("持续倒计时 是否检查, 0是不开启, 1是开启分秒, 2是时分秒")]
	public int CheckBuffTime;

	public GameObject BuffTimeUiRoot;

	public TextMeshProUGUI BuffTimeText;

	[Header("加成因数 是否检查")]
	public bool CheckFactor;

	public float AppearTimer;

	public MaskableGraphic SelfMaskGraphic;

	protected override void ProcessAwake()
	{
	}

	protected override void ProcessDestroy()
	{
	}

	public void ForceUpdate()
	{
	}

	public virtual void SetVisible(bool pVisible, bool pInitTime = false)
	{
	}

	public virtual void InitState()
	{
	}

	public void UpdateState()
	{
	}

	public virtual void ProcessUpdate()
	{
	}

	public override void OnBtnClickEvent()
	{
	}

	public override void ShowPopup()
	{
	}
}
