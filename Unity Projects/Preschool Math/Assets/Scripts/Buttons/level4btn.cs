using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class level4btn : MonoBehaviour {

	private GUISkin skin;
	
	public int buttonWidth;
	public int buttonHeight;
	void Start()
	{
		skin = PlayerController.target == 40 ? Resources.Load ("lev4") as GUISkin : Resources.Load ("lev4lock") as GUISkin;
	}
	
	void OnGUI()
	{
		GUI.skin = skin;
		Rect buttonRect = new Rect(
			(4 * Screen.width / 6) - (buttonWidth / 2),
			(Screen.height / 2) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);

		if(GUI.Button(buttonRect,""))
		{
			if(PlayerController.target == 40)
				SceneManager.LoadScene("31to40");
		}
	}
}
