using UnityEngine;


class GameInteractSuccessState : GameState
{
	public override void Begin()
	{
		delay = 0.3f;

		session.soundEffects.PlayOneShot("Success");

		session.score.Success();
		session.player.Move(1, session.level.moveMultiplier);
		session.inputKey.Happy();
		session.currentInput = null;
	}

	public override void Update()
	{
		delay -= Time.deltaTime;

		if (delay <= 0f)
		{
			if (session.player.transform.localPosition.x > 0.45f)
			{
				ChangeState(new GameLevelCompleteState());
			}
			else
			{
				ChangeState(new GameNextState());
			}
		}
	}


}







