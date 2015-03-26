
public class GameRestartState : GameState
{
	public override void Begin()
	{
		ChangeState(new GameStartState());
	}
}


