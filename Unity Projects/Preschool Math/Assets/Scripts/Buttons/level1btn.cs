using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class level1btn : MonoBehaviour
{
	private GUISkin skin;
	
	public int buttonWidth;
	public int buttonHeight;
	void Start()
	{
		skin = Resources.Load ("lev1") as GUISkin;
	}
	
	void OnGUI()
	{
		GUI.skin = skin;
		Rect buttonRect = new Rect(
			(Screen.width / 6) - (buttonWidth / 2),
			(Screen.height / 2) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);

		if(GUI.Button(buttonRect,""))
		{
			SceneManager.LoadScene("1to10");
		}
	}
}
