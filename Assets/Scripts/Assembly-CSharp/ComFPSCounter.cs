using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ComFPSCounter : MonoBehaviour
{
	public float UpdateInterval;

	protected float _framesAccumulated;

	protected float _framesDrawnInTheInterval;

	protected float _timeLeft;

	protected int _currentFPS;

	protected TextMeshProUGUI _TextTmp;

	private static string[] _stringsFrom00To300;

	protected virtual void Start()
	{
	}

	protected virtual void Update()
	{
	}
}
