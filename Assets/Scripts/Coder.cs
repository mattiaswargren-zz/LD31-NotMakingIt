using UnityEngine;

public class Coder : MonoBehaviour
{

	float moveSize = 0.05f;

	Vector3 startPosition;


	public void Reset()
	{
		transform.localPosition = startPosition;
	}

	void Awake()
	{
		startPosition = transform.localPosition;
	}

	void Update()
	{
		
	}


	public void Move(float pDirection, float pMultiplier = 1f)
	{
		var newPosition = transform.localPosition;
		newPosition.x += (pDirection * (moveSize * pMultiplier));
		transform.localPosition = newPosition;
	}

	public void Walk()
	{
		TriggerAnimator("Walking");
	}

	public void Dead()
	{
		TriggerAnimator("Dead");
	}

	public void Happy()
	{
		TriggerAnimator("Happy");
	}

	void TriggerAnimator(string pKey)
	{
		GetComponentInChildren<Animator>().SetTrigger(pKey);
	}
}
