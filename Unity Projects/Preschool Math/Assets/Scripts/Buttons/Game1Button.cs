using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Game1Button : MonoBehaviour
{
	private GUISkin skin;
	
	public int buttonWidth;
	public int buttonHeight;
	void Start()
	{
		skin = Resources.Load ("Game1SM") as GUISkin;
	}
	
	void OnGUI()
	{
		GUI.skin = skin;
		// Determine the button's place on screen
		// Center in X, 2/3 of the height in Y
		Rect buttonRect = new Rect(
			(Screen.width / 4) - (buttonWidth / 2),
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
			SceneManager.LoadScene("1to10");
		}
	}
}
