using UnityEngine;

public class GameLevel
{
	public KeyInput[] inputs;
	public KeyCode[] validKeys = {
		KeyCode.L,
		KeyCode.D,
		KeyCode.Alpha3,
		KeyCode.Alpha1,
		KeyCode.S,
		KeyCode.F,
		KeyCode.Alpha2,
		KeyCode.Alpha4,
		KeyCode.K
	};

	public bool randomize;
	public float moveMultiplier;

	public GameLevel(KeyInput[] pInputs, bool pRandomize, float pMoveMultiplier = 1f)
	{
		inputs = pInputs;
		randomize = pRandomize;
		moveMultiplier = Mathf.Max(1f, pMoveMultiplier);
	}

	public KeyInput GetRandomInput()
	{
		return inputs[Random.Range(0, inputs.Length)];
	}

	public KeyInput GetInput(int pIndex)
	{
		return inputs[pIndex];
	}
}

public class KeyInput
{
	public string id;
	public KeyCode key;

	public KeyInput(string pId, KeyCode pKey)
	{
		id = pId;
		key = pKey;
	}
}


