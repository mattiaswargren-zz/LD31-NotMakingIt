using UnityEngine;


public class ConsumableFloat
{
	float min;
	float max;
	float change;
	float value;

	public ConsumableFloat(float pMin, float pMax, float pChange)
	{
		min = pMin;
		max = pMax;
		value = pMax;
		change = pChange;
	}

	public float Move(float pModifier = 1f)
	{
		value = Mathf.Max(min, value - (change * pModifier));
		return value;
	}

	public float Current
	{
		get{ return value; }
	}
}

