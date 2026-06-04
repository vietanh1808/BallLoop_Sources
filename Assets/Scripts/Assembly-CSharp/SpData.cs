using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class SpData
{
	[Header("*必填*特殊机制类型")]
	public SpType Type;

	[Header("需要完成的目标数")]
	[Tooltip("例如木箱子围栏需要击碎的次数")]
	[Range(0f, 999f)]
	public int GoalNum;

	public int CurNum;

	[Header("关联的格子坐标 x:行 y:列")]
	[Tooltip("例如占用多个格子的机制 需要给定多个坐标点(格子坐标)")]
	[JsonIgnore]
	public List<Vector2Int> Points;

	[HideInInspector]
	public List<NavVec2> NPList;

	[Tooltip("服务于弹出平台机制及类似机制 给定格子和生成的球的颜色信息")]
	[Header("*新-弹出平台*关联的格子坐标 x:行 y:列")]
	public List<SpTCPC> TCPCList;

	[Tooltip("例如生成器需要生成的球的颜色和数量")]
	[Header("包含的颜色和数量")]
	public List<ColorNumPara> ColorParas;

	[Header("特殊机制同类型下的分组")]
	[Tooltip("例如钥匙要区分不同颜色的钥匙和锁\n又例如多个断裂路段需要区分不同的路段和铲子")]
	public string Group;

	[Header("特殊机制同类型下的分组内的排序")]
	public int Order;

	[Header("特殊机制同类型下的分组内的排序后的标记")]
	public string Tag;

	[Header("包含的颜色列表*自动处理无需填写*")]
	[JsonIgnore]
	public List<ColorType> ContainColors;
}
