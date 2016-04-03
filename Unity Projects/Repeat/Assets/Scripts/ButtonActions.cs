using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonActions : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void play(){
		GameObject.Find ("btn").GetComponent<AudioSource> ().Play ();
		SceneManager.LoadScene("game");
	}
}
