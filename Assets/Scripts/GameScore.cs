using UnityEngine;

public class GameScore
{
	float success;
	float fail;

	public void Success()
	{
		success++;
	}

	public void Fail()
	{
		fail++;
	}

	public string accuracy
	{
		get
		{
			if (total == 0)
			{
				return 1.ToString("P");
			}

			return (success / total).ToString("P");
		}
	}

	public int total
	{
		get
		{ 
			return (int)(success + fail);
		}
	}
}
