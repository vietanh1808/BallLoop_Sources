using UnityEngine;

[AddComponentMenu("LeanTween/LeanTweenPath")]
public class LeanTweenPath : MonoBehaviour
{
	public enum LeanTweenPathType
	{
		bezier = 0,
		spline = 1
	}

	public int count;

	public Transform[] pts;

	public Vector3[] path;

	public LeanTweenPathType pathType;

	public float controlSize;

	public bool showArrows;

	public bool nodesMaximized;

	public bool creatorMaximized;

	public bool importMaximized;

	private int i;

	private int k;

	public int lastCount;

	public static Color curveColor;

	public static Color lineColor;

	public Vector3[] vec3
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void init()
	{
	}

	private void reset()
	{
	}

	public Transform createChild(int i, Vector3 pos)
	{
		return null;
	}

	private void initNode(Transform trans, int i)
	{
	}

	private void Start()
	{
	}

	public void OnDrawGizmos()
	{
	}

	public Vector3[] splineVector()
	{
		return null;
	}

	public Vector3[] splineVectorNoEndCaps()
	{
		return null;
	}

	private void resetPath()
	{
	}

	public void addNode()
	{
	}

	public void addNodeAfter(int after)
	{
	}

	public void deleteNode(int i)
	{
	}
}
