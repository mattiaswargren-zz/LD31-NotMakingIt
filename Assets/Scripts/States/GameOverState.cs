
public class GameOverState : GameState
{
	TypeWriter typewriter;

	public override void Begin()
	{
		session.inputKey.Hide();

		session.soundEffects.PlayOneShot("DieBit");
		session.player.Dead();

		typewriter = new TypeWriter(string.Format(GameSession.GAMEOVER, session.levelIndex+1, session.score.accuracy));
	}

	public override void Update()
	{
		if (!typewriter.isComplete)
		{
			session.ui.instruction.text = typewriter.Update();
			return;
		}

		if (anyKey)
		{
			session.cameraShake.MilkShake();
			session.soundEffects.PlayOneShot("Confirm");
			ChangeState(new GameRestartState());
		}
	}

	public override void End()
	{
		session.ui.instruction.text = "";
	}
}






