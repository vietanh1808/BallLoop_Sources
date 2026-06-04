using UnityEngine;

public enum SpType
{
	[InspectorName("球机制 - 盲球")]
	Bead_Mang = 0,
	[InspectorName("球机制 - 冰冻球")]
	Bead_Bing = 1,
	[InspectorName("球机制 - 断裂路段的铲子")]
	Bead_DuanLieLuDuan = 2,
	[InspectorName("球机制 - 密封容器的剪刀")]
	Bead_MiFengRongQi = 3,
	[InspectorName("球机制 - 隐匿小球")]
	Bead_YinNiXiaoQiu = 4,
	[InspectorName("球机制 - 引力球 *暂不开启*")]
	Bead_YinLi = 200,
	[InspectorName("格子机制 - 生成器")]
	Cell_ShengChengQi = 1000,
	[InspectorName("格子机制 - 围栏箱子")]
	Cell_WeiLan = 1001,
	[InspectorName("格子机制 - 宝箱")]
	Cell_BaoXiang = 1002,
	[InspectorName("格子机制 - 透明生成器")]
	Cell_TouMingShengChengQi = 1003,
	[InspectorName("格子机制 - 空间锁")]
	Cell_KongJianSuo = 1004,
	[InspectorName("格子机制 - 封锁木箱")]
	Cell_FengSuoMuXiang = 1005,
	[InspectorName("格子机制 - 弹出平台")]
	Cell_TanChuPingTai = 1006,
	[InspectorName("格子机制 - 断裂路段")]
	Cell_DuanLieLuDuan = 1007,
	[InspectorName("格子机制 - 激光发射器")]
	Cell_JiGuangFaSheQi = 1008,
	[InspectorName("格子机制 - 色感路障")]
	Cell_SeGanLuZhang = 1009,
	[InspectorName("格子机制 - 火箭发射器")]
	Cell_HuoJianFaSheQi = 1010,
	[InspectorName("格子机制 - 神秘礼物")]
	Cell_ShenMiLiWu = 1011,
	[InspectorName("格子机制 - 炸弹球")]
	Cell_ZhaDanQiu = 1012,
	[InspectorName("格子机制 - 脉冲闸门")]
	Cell_MaiChongZhaMen = 1013,
	[InspectorName("格子机制 - 塌陷 *暂不开启*")]
	Cell_TaXian = 1200,
	[InspectorName("容器机制 - 盲盒容器")]
	Box_Mang = 2000,
	[InspectorName("容器机制 - 密封容器")]
	Box_MiFengRongQi = 2001,
	[InspectorName("出口机制 - 出口塞")]
	Exit_SaiZi = 3000
}
