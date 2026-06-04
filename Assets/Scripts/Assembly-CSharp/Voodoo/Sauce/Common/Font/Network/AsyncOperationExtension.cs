using System.Runtime.CompilerServices;
using UnityEngine;

namespace Voodoo.Sauce.Common.Font.Network
{
	public static class AsyncOperationExtension
	{
		public static TaskAwaiter GetAwaiter(this AsyncOperation asyncOp)
		{
			return default(TaskAwaiter);
		}
	}
}
