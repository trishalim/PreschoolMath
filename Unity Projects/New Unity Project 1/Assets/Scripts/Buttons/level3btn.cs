using UnityEngine;
using System.Collections;

public class level3btn : MonoBehaviour {

	private GUISkin skin;
	
	public int buttonWidth;
	public int buttonHeight;
	void Start()
	{
		skin = PlayerController.target == 30 ? Resources.Load ("lev3") as GUISkin : Resources.Load ("lev3lock") as GUISkin;
	}
	
	void OnGUI()
	{
		GUI.skin = skin;
		// Determine the button's place on screen
		// Center in X, 2/3 of the height in Y
		Rect buttonRect = new Rect(
			(Screen.width / 2) - (buttonWidth / 2),
			(Screen.height / 2) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);
		
		// Draw a button to start the game
		if(GUI.Button(buttonRect,""))
		{
			if(PlayerController.target == 30)
				Application.LoadLevel("21to30");
		}
	}
}
