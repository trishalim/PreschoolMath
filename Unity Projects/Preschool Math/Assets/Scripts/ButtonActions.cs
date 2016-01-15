using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonActions : MonoBehaviour
{
	void Start(){
		GameObject btn;

		//Game 2 Levels
		if (SceneManager.GetActiveScene ().buildIndex == 7) {
			int lo = (PlayerController.target / 10);
			string but;
			for (int i = 1; i <= lo; i++) {
				but = "Button" + i.ToString ();
				btn = GameObject.Find (but);
				btn.GetComponent<Button> ().interactable = true;
			}		
		}

		//Main Menu
		if (SceneManager.GetActiveScene ().buildIndex == 0) {
			btn = GameObject.Find ("MainBtn");
			btn.GetComponent<RectTransform> ().sizeDelta.Set(300, 100);
		}
	}

	public void LoadSub()
	{
		SceneManager.LoadScene("submenu");
	}

	public void LoadGame2()
	{
		SceneManager.LoadScene("game2levels");
	}

	public void LoadGame2()
	{
		SceneManager.LoadScene("game3");
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
