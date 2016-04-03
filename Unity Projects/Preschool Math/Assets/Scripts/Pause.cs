using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour {
	string obj;
	// Use this for initialization
	void Start () {
		obj = gameObject.name;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		if (obj == "exit")
			StartCoroutine (pause ());
		else if (obj == "resume")
			resume ();
		else if (obj == "restart" || obj == "again")
			restart ();
		else if (obj == "quit" || obj == "back")
			quit ();
	}

	IEnumerator pause(){
		if (SceneManager.GetActiveScene ().name == "game1")
			G1A (false);
		if (SceneManager.GetActiveScene ().name == "game3")
			G3A (false);
		if (SceneManager.GetActiveScene ().name == "sub")
			G3S (false);
		if (SceneManager.GetActiveScene ().buildIndex > 11 && SceneManager.GetActiveScene ().buildIndex < 22)
			G2 (false);
		if ((SceneManager.GetActiveScene ().buildIndex < 22 && SceneManager.GetActiveScene ().buildIndex > 11) || SceneManager.GetActiveScene ().name == "sub")
			pauz2 (true);
		else
			pauz (true);
		Time.timeScale = 0;
		yield return new WaitForSeconds (0.1f);
	}

	void pauz(bool action){
		GameObject.Find ("pause").GetComponent<SpriteRenderer> ().enabled = action;
		GameObject.Find ("pausemenu").GetComponent<SpriteRenderer> ().enabled = action;
		GameObject.Find ("resumebtn").GetComponent<Image> ().enabled = action;
		GameObject.Find ("resumebtn").GetComponent<Button> ().interactable = action;
		GameObject.Find ("restartbtn").GetComponent<Image> ().enabled = action;
		GameObject.Find ("restartbtn").GetComponent<Button> ().interactable = action;
		GameObject.Find ("quitbtn").GetComponent<Image> ().enabled = action;
		GameObject.Find ("quitbtn").GetComponent<Button> ().interactable = action;
	}

	void pauz2(bool action){
		GameObject.Find ("pause").GetComponent<SpriteRenderer> ().enabled = action;
		GameObject.Find ("pausemenu").GetComponent<SpriteRenderer> ().enabled = action;
		GameObject.Find ("resume").GetComponent<SpriteRenderer> ().enabled = action;
		GameObject.Find ("resume").GetComponent<BoxCollider2D> ().enabled = action;
		GameObject.Find ("restart").GetComponent<SpriteRenderer> ().enabled = action;
		GameObject.Find ("restart").GetComponent<BoxCollider2D> ().enabled = action;
		GameObject.Find ("quit").GetComponent<SpriteRenderer> ().enabled = action;
		GameObject.Find ("quit").GetComponent<BoxCollider2D> ().enabled = action;
	}

	void G1A(bool action){
		GameObject.Find ("exit").GetComponent<CircleCollider2D> ().enabled = action;
		for (int i = 1; i < 10; i++) {
			GameObject.Find ("shape" + i.ToString ()).GetComponent<BoxCollider2D> ().enabled = action;
		}
	}

	void G3A(bool action){
		GameObject.Find ("exit").GetComponent<CircleCollider2D> ().enabled = action;
		for (int i = 0; i < 3; i++) {
			GameObject.Find ("choice" + i.ToString ()).GetComponent<BoxCollider2D> ().enabled = action;
		}
	}

	void G3S(bool action){
		GameObject.Find ("exit").GetComponent<CircleCollider2D> ().enabled = action;
		for (int i = 0; i < 3; i++) {
			GameObject.Find ("ans" + i.ToString ()).GetComponent<BoxCollider2D> ().enabled = action;
		}
	}

	void G2(bool action){
		GameObject.Find ("exit").GetComponent<CircleCollider2D> ().enabled = action;
		GameObject.Find ("Player").GetComponent<PlayerController> ().enabled = action;
		GameObject.Find ("Player").GetComponent<Animator> ().enabled = action;
		GameObject.Find ("Ground").GetComponent<GroundController> ().enabled = action;
		GameObject.Find ("Ground2").GetComponent<GroundController> ().enabled = action;
	}

	public void resume(){
		Time.timeScale = 1;
		if ((SceneManager.GetActiveScene ().buildIndex < 22 && SceneManager.GetActiveScene ().buildIndex > 11) || SceneManager.GetActiveScene ().name == "sub")
			pauz2 (false);
		else
			pauz (false);
		if (SceneManager.GetActiveScene ().name == "game1")
			G1A (true);
		if (SceneManager.GetActiveScene ().name == "game3")
			G3A (true);
		if (SceneManager.GetActiveScene ().name == "sub")
			G3S (true);
		if (SceneManager.GetActiveScene ().buildIndex < 22 && SceneManager.GetActiveScene ().buildIndex > 11)
			G2 (true);
	}

	public void restart(){
		Time.timeScale = 1;
		Game3Sub.repeat = 0;
		G1.counter = 0;
		PlayerController.lives = 5;
		Congrats.score = 0;
		SceneManager.LoadScene (PlayerController.currentgame);
	}

	public void quit(){
		Time.timeScale = 1;
		Game3Sub.repeat = 0;
		G1.counter = 0;
		PlayerController.lives = 5;
		Congrats.score = 0;
		SceneManager.LoadScene ("submenu");
	}
}
