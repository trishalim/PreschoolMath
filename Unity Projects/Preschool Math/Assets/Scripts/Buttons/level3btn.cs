using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

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
		Rect buttonRect = new Rect(
			(Screen.width / 2) - (buttonWidth / 2),
			(Screen.height / 2) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);

		if(GUI.Button(buttonRect,""))
		{
			if(PlayerController.target == 30)
				SceneManager.LoadScene("21to30");
		}
	}
}
