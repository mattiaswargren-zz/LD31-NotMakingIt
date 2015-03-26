using UnityEngine;
using UnityEngine.UI;

public class GameRunner : MonoBehaviour
{

	GameStateMachine statemachine;
	GameSession session;

	void Start()
	{
		session = new GameSession();
		session.ui = GetComponentInChildren<GameUI>();
		session.player = GetComponentInChildren<Coder>();
		session.inputKey = GetComponentInChildren<InputKey>();
		session.cameraShake = GetComponentInChildren<CameraShake>();
		session.soundEffects = GetComponentInChildren<SoundEffects>();

		statemachine = new GameStateMachine();
		statemachine.OnVerify = (pState) =>
		{
			pState.session = session;
			return pState;
		};

		statemachine.ChangeState(new GameBootState());
	}

	void Update()
	{
		statemachine.Update();
	}

}
