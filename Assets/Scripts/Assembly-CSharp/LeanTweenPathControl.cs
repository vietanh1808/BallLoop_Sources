using UnityEngine;

[ExecuteInEditMode]
public class LeanTweenPathControl : MonoBehaviour
{
	private Vector3 lastPos;

	private Vector3[] lastPosControl;

	public LeanTweenPathControl[] controlRef;

	public int i;

	public bool isControl;

	public bool isBezier;

	private static Material matPoints;

	private static Material matControls;

	public void createMaterials()
	{
	}

	private void OnEnable()
	{
	}

	private void OnApplicationFocus()
	{
	}

	private void OnBecameInvisible()
	{
	}

	private void OnDisable()
	{
	}

	public void init(LeanTweenPathControl[] controlRef, int i, bool isControl)
	{
	}

	public void init(int i)
	{
	}

	private void OnDrawGizmos()
	{
	}
}
