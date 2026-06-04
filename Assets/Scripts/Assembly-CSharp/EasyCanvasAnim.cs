using System.Collections.Generic;

public class EasyCanvasAnim
{
	public float AnimTime;

	public float DelayTime;

	public List<string> Groups { get; set; }

	public List<string> Names { get; set; }

	public bool State { get; set; }

	public EasyCanvasAnim()
	{
	}

	public EasyCanvasAnim(List<string> pGroups, List<string> pNames, bool pState, float pTime, float pDelay)
	{
	}
}
