using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TimeFreeze /*: MonoBehaviour */
{

	
	private static float interpolationFactor = 0.05f;

	public static void move()
	{
		Time.timeScale = Mathf.Lerp(Time.timeScale, 1, interpolationFactor);
		Time.fixedDeltaTime = Time.timeScale * 0.02f;		
		
	}
	
	public static void stop()
	{
		Time.timeScale = Mathf.Lerp(0, Time.timeScale, 1 - interpolationFactor);
		Time.fixedDeltaTime = Time.timeScale * 0.02f;	
	}
}
