using UnityEngine;


public class GameLogoState : GameState
{
	public override void Begin()
	{

	}

	public override void Update()
	{
		if (anyKey)
		{
			session.soundEffects.PlayOneShot("Confirm");
			session.cameraShake.MilkShake();

			session.ui.HideLogo();

			ChangeState(new GameInstructionsState());
		}
	}
}


