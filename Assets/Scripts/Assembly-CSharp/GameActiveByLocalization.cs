using System.Collections.Generic;
using UnityEngine;

public class GameActiveByLocalization : MonoBehaviour
{
	[Header("开启表示在下列表范围内激活，否则隐藏")]
	public bool ActiveByList;

	public List<SystemLanguage> LangList;

	private void Start()
	{
	}
}
