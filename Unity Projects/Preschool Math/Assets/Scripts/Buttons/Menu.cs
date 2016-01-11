using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
	private GUISkin skin;

	public int buttonWidth;
	public int buttonHeight;
	void Start()
	{
		skin = Resources.Load ("GUISkin") as GUISkin;
	}

	void OnGUI()
	{
		GUI.skin = skin;
		Rect buttonRect = new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);

		if(GUI.Button(buttonRect,"PLAY"))
		{
			float fadeTime = GameObject.Find("TITLE").GetComponent<Fading>().BeginFade(1);
			new WaitForSeconds(fadeTime);
			SceneManager.LoadScene("submenu");
		}
	}
}
