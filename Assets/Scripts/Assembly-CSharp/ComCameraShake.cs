using UnityEngine;

public class ComCameraShake : MonoBehaviour
{
	[Header("震动节点")]
	public Transform ShakeRoot;

	private float m_Seed;

	public float ShakeValue;

	public Vector3 MaxVec;

	[Header("相机抖动强度")]
	public float Power;

	[Header("相机抖动频率")]
	public float Frequency;

	private float m_Resume;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void StartShake(Vector4 pPara)
	{
	}
}
