using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

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
		Rect buttonRect = new Rect(
			(2 * Screen.width / 6) - (buttonWidth / 2),
			(Screen.height / 2) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);

		if(GUI.Button(buttonRect,""))
		{
			if(PlayerController.target == 20)
				SceneManager.LoadScene("11to20");
		}
	}
}
