using System;

public static class EnumExtensions
{
	public static T ToEnum<T>(this string value) where T : Enum
	{
		return default(T);
	}
}
