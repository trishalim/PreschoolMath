using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		Time.timeScale = 0;
		pauseaction (true);
		GameObject.Find ("Canvas").GetComponent<Canvas> ().enabled = false;
	}

	void pauseaction(bool action){
		GameObject.Find ("pause").GetComponent<SpriteRenderer>().enabled = action;
		GameObject.Find ("pausebg").GetComponent<SpriteRenderer>().enabled = action;
		GameObject.Find ("Canvas2").GetComponent<Canvas>().enabled = action;
	}

	public void resume(){
		Time.timeScale = 1;
		pauseaction (false);
		GameObject.Find ("Canvas").GetComponent<Canvas> ().enabled = true;
	}

	public void exit(){
		SceneManager.LoadScene ("main");
	}
}
