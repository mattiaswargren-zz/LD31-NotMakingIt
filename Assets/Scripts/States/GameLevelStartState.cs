using UnityEngine;


public class GameLevelStartState : GameState
{

	TypeWriter typeWriter;

	public override void Begin()
	{
		delay = 1.5f; 

		session.soundEffects.PlayOneShot("Level");

		session.inputKey.Hide();

		session.player.Reset();
		session.player.Walk();
		session.levelIndex++;

		session.level = session.levels[Mathf.Min(session.levelIndex, session.levels.Length - 1)];

		typeWriter = new TypeWriter(string.Format(GameSession.LEVEL, session.levelIndex + 1));
	}

	public override void Update()
	{
		if (!typeWriter.isComplete)
		{
			session.ui.instruction.text = typeWriter.Update();
			return;
		}

		delay -= Time.deltaTime;

		if (delay <= 0f)
		{
			ChangeState(new GameNextState());
		}
	}

	public override void End()
	{
		session.ui.instruction.text = "";
	}

}





