using UnityEngine;

public class GameInteractState : GameState
{
	float total;
	float progress;

	public override void Begin()
	{
		total = delay = session.settingsLife.Move(1f * session.reactionAccuracy);

		session.inputKey.Show();
		session.inputKey.SetKey(session.currentInput.id);
	}

	public override void Update()
	{
		delay -= Time.deltaTime;
		progress = (delay / total);

		if (delay <= 0f)
		{
			Failed();
		}

		session.inputKey.Progress(progress);

		if (session.currentInput != null)
		{
			foreach (var ik in session.level.validKeys)
			{
				if (Input.GetKeyDown(ik))
				{
					if (ik == session.currentInput.key)
					{
						Success();
					}
					else
					{
						Failed();
					}
					return;
				}
			}
		}


	}



	void Success()
	{
		session.reactionAccuracy = 1f - progress;
		ChangeState(new GameInteractSuccessState());
	}

	void Failed()
	{
		session.reactionAccuracy = 1f - 0f;
		ChangeState(new GameInteractFailState());
	}
}






