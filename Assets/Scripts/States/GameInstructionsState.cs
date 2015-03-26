using UnityEngine;


public class GameInstructionsState : GameState
{

	TypeWriter typewriter;

	public override void Begin()
	{
		session.player.Walk();
		typewriter = new TypeWriter(GameSession.INSTRUCTION);
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
			session.soundEffects.PlayOneShot("Confirm");
			ChangeState(new GameStartState());
		}
	}

	public override void End()
	{
		session.ui.instruction.text = "";
	}
}


