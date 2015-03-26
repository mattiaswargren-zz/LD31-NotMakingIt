using UnityEngine;


public class GameNextState : GameState
{

	public override void Begin()
	{
		session.inputKey.Show();
		session.inputKey.Empty();

		delay = session.settingsDelay.Move(1f * session.reactionAccuracy);

		if (session.level.randomize)
		{
			session.currentInput = session.level.GetRandomInput();
		}
		else
		{
			session.currentInput = session.level.GetInput(session.score.total % session.level.inputs.Length);
		}
	}

	public override void Update()
	{
		delay -= Time.deltaTime;

		if (delay <= 0f)
		{
			ChangeState(new GameInteractState());
		}
	}
}





