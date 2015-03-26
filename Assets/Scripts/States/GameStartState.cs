using UnityEngine;


public class GameStartState : GameState
{
	public override void Begin()
	{
		delay = 1f; 

		session.score = new GameScore();
		session.settingsDelay = new ConsumableFloat(0.45f, 0.8f, 0.008f);
		session.settingsLife = new ConsumableFloat(0.6f, 3f, 0.04f);
		session.levelIndex = -1;

	}

	public override void Update()
	{
		delay -= Time.deltaTime;

		if (delay <= 0f)
		{
			ChangeState(new GameLevelStartState());
		}
	}

	public override void End()
	{

	}
}