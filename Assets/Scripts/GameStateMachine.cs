using UnityEngine;


class GameStateMachine
{
	public delegate GameState VerifyFunction(GameState pState);
	public VerifyFunction OnVerify = (pState) => pState;

	GameState currentState;

	public void ChangeState(GameState pState)
	{
		// END
		if (currentState != null)
		{
			currentState.End();
		}

		// CHANGE
		//Debug.Log(string.Format("Change from {0} to {1}", currentState, pState));
		currentState = pState;

		// BEGIN
		if (currentState != null)
		{
			currentState = OnVerify(pState);
			currentState.ChangeState = ChangeState;
			currentState.Begin();

		}
	}

	public void Update()
	{
		if (currentState != null)
		{
			currentState.Update();
		}
	}

}

