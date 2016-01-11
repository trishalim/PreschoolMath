using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class level5btn : MonoBehaviour {

	private GUISkin skin;
	
	public int buttonWidth;
	public int buttonHeight;
	void Start()
	{
		skin = PlayerController.target == 50 ? Resources.Load ("lev5") as GUISkin : Resources.Load ("lev5lock") as GUISkin;
	}
	
	void OnGUI()
	{
			GUI.skin = skin;
			// Determine the button's place on screen
			// Center in X, 2/3 of the height in Y
			Rect buttonRect = new Rect (
			(5 * Screen.width / 6) - (buttonWidth / 2),
			(Screen.height / 2) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);
		
			// Draw a button to start the game
			if (GUI.Button (buttonRect, "")) {
				if(PlayerController.target == 50)
				SceneManager.LoadScene ("41to50");
			}
	}
}
