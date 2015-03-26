using UnityEngine.UI;
using UnityEngine;

public class GameUI : MonoBehaviour
{
	Transform logo;
	public Text instruction;

	void Start()
	{
		logo = transform.Find("Logo");
	}



	public void HideLogo()
	{
		Destroy(logo.gameObject);
	}
}
