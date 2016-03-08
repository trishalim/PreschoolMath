using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour {
	static bool AudioBegin = false;
	// Use this for initialization
	void Awake () {
		if (!AudioBegin) {
			GetComponent<AudioSource> ().Play ();
			DontDestroyOnLoad (gameObject);
			AudioBegin = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (SceneManager.GetActiveScene ().name != "game3" && SceneManager.GetActiveScene ().name != "sub" && SceneManager.GetActiveScene ().name != "game1") {
			GetComponent<AudioSource> ().Stop ();
			AudioBegin = false;
		}
	}
}
