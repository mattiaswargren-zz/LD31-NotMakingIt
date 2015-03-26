using UnityEngine;

public class InputKey : MonoBehaviour
{
	Transform bar;

	Vector3 barSize;

	void Start()
	{
		bar = transform.Find("Bar").transform;
		barSize = bar.localScale;
		Hide();
	}

	public void Progress(float pPercent)
	{
		bar.transform.localScale = new Vector2(barSize.x * pPercent, barSize.y);
	}

	public void SetKey(string pKey)
	{
		GetComponent<Animator>().SetTrigger(pKey);
	}

	public void Happy()
	{
		SetKey("Happy");
		EnableParticles();
	}

	void EnableParticles()
	{
		GetComponentInChildren<ParticleSystem>().enableEmission = true;
	}

	void DisableParticles()
	{
		GetComponentInChildren<ParticleSystem>().enableEmission = false;
	}

	public void Empty()
	{
		SetKey("Empty");
	}

	public void Hide()
	{
		foreach (var r in GetComponentsInChildren<Renderer>())
		{
			r.enabled = false;
		}

		DisableParticles();

		Progress(0f);
	}

	public void Show()
	{
		foreach (var r in GetComponentsInChildren<Renderer>())
		{
			r.enabled = true;
		}

		DisableParticles();
	}
}
