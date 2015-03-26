using UnityEngine;


public class GameState
{

	protected float delay = 0f;

	public GameSession session
	{
		get;
		set;
	}

	protected bool anyKey
	{
		get
		{
			return Input.anyKeyDown || Input.touches.Length > 0;
		}
	}

	public System.Action<GameState> ChangeState { get; set; }

	public virtual void Begin()
	{
		
	}

	public virtual  void Update()
	{
		
	}

	public virtual  void End()
	{
		
	}
}

