using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Game3Button : MonoBehaviour
{
	private GUISkin skin;
	
	public int buttonWidth;
	public int buttonHeight;
	void Start()
	{
		skin = Resources.Load ("Game3SM") as GUISkin;
	}
	
	void OnGUI()
	{
		GUI.skin = skin;
		Rect buttonRect = new Rect(
			(3 * Screen.width / 4) - (buttonWidth / 2),
			(Screen.height / 2) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);

		if(GUI.Button(buttonRect,""))
		{
			float fadeTime = GameObject.Find("TITLE").GetComponent<Fading>().BeginFade(1);
			new WaitForSeconds(fadeTime);
			SceneManager.LoadScene("1to10");
		}
	}
}
