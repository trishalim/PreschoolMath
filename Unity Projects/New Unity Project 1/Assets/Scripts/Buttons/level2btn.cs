using UnityEngine;
using System.Collections;

public class level2btn : MonoBehaviour {

	private GUISkin skin;
	
	public int buttonWidth;
	public int buttonHeight;
	void Start()
	{
		skin = PlayerController.target == 20 ? Resources.Load ("lev2") as GUISkin : Resources.Load ("lev2lock") as GUISkin;
	}
	
	void OnGUI()
	{
		GUI.skin = skin;
		// Determine the button's place on screen
		// Center in X, 2/3 of the height in Y
		Rect buttonRect = new Rect(
			(2 * Screen.width / 6) - (buttonWidth / 2),
			(Screen.height / 2) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);
		
		// Draw a button to start the game
		if(GUI.Button(buttonRect,""))
		{
			if(PlayerController.target == 20)
				Application.LoadLevel("11to20");
		}
	}
}
