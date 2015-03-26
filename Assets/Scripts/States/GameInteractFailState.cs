using UnityEngine;


public class GameInteractFailState : GameState
{
	public override void Begin()
	{
		delay = 0.3f;

		session.soundEffects.PlayOneShot("Fail");

		session.score.Fail();

		session.player.Move(-1, session.level.moveMultiplier);
		session.inputKey.SetKey("Sad");
		session.currentInput = null;
		session.cameraShake.Shake(0.4f);
	}

	public override void Update()
	{
		delay -= Time.deltaTime;

		if (session.player.transform.localPosition.x < -0.7f)
		{
			ChangeState(new GameOverState());
		}
		else
		{
			ChangeState(new GameNextState());
		}
	}
}







