using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	GameObject cir;
	int exit = 0;
	// Use this for initialization
	void Start () {
		cir = GameObject.Find ("rot");
		GameProper.repeat = 0;
		GameProper.length = 3;
	}
	
	// Update is called once per frame
	void Update () {
		cir.transform.Rotate(0, 0, 30 * Time.deltaTime);
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (exit == 2)
				Application.Quit ();
			else {
				exit++;
				GameObject.Find ("backagain").GetComponent<SpriteRenderer> ().enabled = true;
			}
		}
	}
}
