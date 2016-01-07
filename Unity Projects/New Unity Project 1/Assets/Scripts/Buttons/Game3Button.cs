using UnityEngine;
using System.Collections;

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
		// Determine the button's place on screen
		// Center in X, 2/3 of the height in Y
		Rect buttonRect = new Rect(
			(3 * Screen.width / 4) - (buttonWidth / 2),
			(Screen.height / 2) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);
		
		// Draw a button to start the game
		if(GUI.Button(buttonRect,""))
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			float fadeTime = GameObject.Find("TITLE").GetComponent<Fading>().BeginFade(1);
			new WaitForSeconds(fadeTime);
			Application.LoadLevel("1to10");
		}
	}
}
