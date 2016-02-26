using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonActions : MonoBehaviour
{
	void Start(){
		GameObject btn;

		//Game 2 Levels
		if (SceneManager.GetActiveScene ().name == "game2levels") {
			int lo = (PlayerController.target / 10);
			string but;
			for (int i = 1; i <= lo; i++) {
				but = "Button" + i.ToString ();
				btn = GameObject.Find (but);
				btn.GetComponent<Button> ().interactable = true;
			}		
		}
	}

	public void LoadLev1()
	{
		SceneManager.LoadScene("1to10");
	}

	public void LoadLev2()
	{
		SceneManager.LoadScene("11to20");
	}

	public void LoadLev3()
	{
		SceneManager.LoadScene("21to30");
	}

	public void LoadLev4()
	{
		SceneManager.LoadScene("31to40");
	}

	public void LoadLev5()
	{
		SceneManager.LoadScene("41to50");
	}
}
