using UnityEngine;


class GameBootState : GameState
{

	override public void Begin()
	{
		var inputs = new KeyInput[]{
			new KeyInput("KeyL", KeyCode.L),
			new KeyInput("KeyD", KeyCode.D),
			new KeyInput("Key3", KeyCode.Alpha3),
			new KeyInput("Key1", KeyCode.Alpha1)
		};

		session.levelIndex = -1;
		session.levels = new GameLevel[]{
			new GameLevel(new KeyInput[]{inputs[0],inputs[1]}, false, 3),
			new GameLevel(new KeyInput[]{inputs[2],inputs[3]}, false, 3),
			new GameLevel(new KeyInput[]{inputs[0],inputs[1]}, true, 3),
			new GameLevel(new KeyInput[]{inputs[2],inputs[3]}, true, 2),
			new GameLevel(inputs, true),
		}; 

		ChangeState(new GameLogoState());
	}

	override public void Update()
	{

	}

	override public void End()
	{

	}

}

