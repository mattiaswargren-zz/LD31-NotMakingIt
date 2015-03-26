using UnityEngine;

public class CameraShake : MonoBehaviour
{
	float shake = 0f;
	float shakeAmount = 0.009f;
	float decreaseFactor = 1.0f;
	Vector3 originalPos;

	void OnEnable()
	{
		originalPos = transform.localPosition;
	}

	void Update()
	{
		if (shake > 0)
		{
			transform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

			shake -= Time.deltaTime * decreaseFactor;
		}
		else
		{
			shake = 0f;
			transform.localPosition = originalPos;
		}
	}

	public void Shake(float pTime)
	{
		shake = pTime;
	}

	public void MilkShake()
	{
		Shake(0.2f);
	}
}