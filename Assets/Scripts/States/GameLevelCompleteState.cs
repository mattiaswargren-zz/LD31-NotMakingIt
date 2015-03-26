using UnityEngine;


public class GameLevelCompleteState : GameState
{
	public override void Begin()
	{
		delay = 2f;
		session.soundEffects.PlayOneShot("Computer");
		session.player.Happy();
	}

	public override void Update()
	{
		delay -= Time.deltaTime;

		if (delay <= 0f)
		{
			ChangeState(new GameLevelStartState());
		}
	}

}








