using System;
using System.Collections.Generic;

public class AssetGld
{
	public string Id;

	public string Type;

	public string Icon;

	public string Quality;

	public List<string> From;

	[Obsolete("道具中文名(编辑器用) 请使用多语言文本接口 LocalizeName")]
	public string Name;

	public string LocalizeName(bool pLocalized = true)
	{
		return null;
	}

	public string LocalizeDes(bool pLocalized = true)
	{
		return null;
	}

	public string LocalizeNotEnough()
	{
		return null;
	}
}
