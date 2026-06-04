using UnityEngine;

public class GamePathHolder : MonoBehaviour
{
	public bool InitAtStart;

	public Transform NodeRoot;

	[Header("是否包含根节点")]
	public bool ContainRoot;

	[Header("特殊开始节点组")]
	public Transform[] StartArray;

	[Header("特殊结束节点组")]
	public Transform[] EndArray;

	public GamePathData SelfPath;

	private void Start()
	{
	}

	public void UpdatePathData()
	{
	}
}
