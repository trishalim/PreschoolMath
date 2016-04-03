using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.Find ("scored").GetComponent<Text> ().text = Score.score.ToString ();
		GameObject.Find ("best").GetComponent<Text> ().text = PlayerPrefs.GetInt ("HS").ToString();
		GameProper.repeat = 0;
		GameProper.length = 3;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
			SceneManager.LoadScene ("main");
	}

	public void again(){
		GameObject.Find ("btn").GetComponent<AudioSource> ().Play ();
		Score.score = 0;
		SceneManager.LoadScene ("game");
	}	

	public void exit(){
		GameObject.Find ("btn").GetComponent<AudioSource> ().Play ();
		sureexit ();
	}

	public void sureexit(){
		GameObject.Find ("pause").GetComponent<SpriteRenderer>().enabled = true;
		GameObject.Find ("pausebg").GetComponent<SpriteRenderer>().enabled = true;
		GameObject.Find ("Canvas2").GetComponent<Canvas>().enabled = true;
		GameObject.Find ("again").GetComponent<Button>().interactable = false;
		GameObject.Find ("exit").GetComponent<Button>().interactable = false;
	}

	public void no(){
		SceneManager.LoadScene ("main");
	}

	public void yes(){
		Application.Quit ();
	}
}
