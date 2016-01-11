using UnityEngine;
using System.Collections;

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
		// Determine the button's place on screen
		// Center in X, 2/3 of the height in Y
		Rect buttonRect = new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);
		
		// Draw a button to start the game
		if(GUI.Button(buttonRect,"PLAY"))
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			float fadeTime = GameObject.Find("TITLE").GetComponent<Fading>().BeginFade(1);
			new WaitForSeconds(fadeTime);
			Application.LoadLevel("submenu");
		}
	}
}
