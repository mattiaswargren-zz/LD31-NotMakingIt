
public class GameSession
{
	public GameUI ui
	{
		get;
		set;
	}

	public float reactionAccuracy
	{
		get;
		set;
	}

	public SoundEffects soundEffects
	{
		get;
		set;
	}

	public CameraShake cameraShake
	{
		get;
		set;
	}

	public int levelIndex
	{
		get;
		set;
	}

	public GameLevel level
	{
		get;
		set;
	}

	public GameLevel[] levels
	{
		get;
		set;
	}

	public GameScore score
	{
		get;
		set;
	}

	public InputKey inputKey
	{
		get;
		set;
	}

	public Coder player
	{
		get;
		set;
	}

	public KeyInput currentInput;
	public ConsumableFloat settingsDelay;
	public ConsumableFloat settingsLife;


	public const string INSTRUCTION = "\n\nQuick time events are stupid right!?\nAnyways ... make this coder happy by getting him to his computer. \n\n<Hit the any key to continue>";
	public const string LEVEL = "\n\n\n\n\nLevel {0}";
	public const string GAMEOVER = "\n\nGame Over!\nLevel: {0} | Accuracy: {1}\n\n<Hit the any key to play again>";
}

