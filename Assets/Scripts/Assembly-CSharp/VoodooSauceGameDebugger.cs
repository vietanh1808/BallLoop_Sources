using UnityEngine.Scripting;
using Voodoo.Sauce.Debugger;

[Preserve]
public class VoodooSauceGameDebugger : CustomDebugger
{
	public override string GetTitle()
	{
		return null;
	}

	public override int GetOrderIndex()
	{
		return 0;
	}

	public override void SetupScreen(Screen screen)
	{
	}

	private string GetLevel()
	{
		return null;
	}

	public void SetLevel(string obj)
	{
	}

	private string GetCoin()
	{
		return null;
	}

	private void SetCoin(string obj)
	{
	}

	private string GetLife()
	{
		return null;
	}

	private void SetLife(string obj)
	{
	}

	private string GetBooster1()
	{
		return null;
	}

	private void SetBooster1(string obj)
	{
	}

	private string GetBooster3()
	{
		return null;
	}

	private void SetBooster3(string obj)
	{
	}

	private string GetBooster2()
	{
		return null;
	}

	private void SetBooster2(string obj)
	{
	}

	private void WinGame()
	{
	}

	private void LoseGame()
	{
	}

	private void HideUI()
	{
	}

	private void ShowUI()
	{
	}
}
