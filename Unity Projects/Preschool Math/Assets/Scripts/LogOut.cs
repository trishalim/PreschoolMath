using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogOut : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void surem(bool action){
		GameObject.Find ("sure").GetComponent<SpriteRenderer> ().enabled = action;
		GameObject.Find ("wrong").GetComponent<SpriteRenderer> ().enabled = action;
		GameObject.Find ("check").GetComponent<SpriteRenderer> ().enabled = action;
		GameObject.Find ("wrong").GetComponent<CircleCollider2D> ().enabled = action;
		GameObject.Find ("check").GetComponent<CircleCollider2D> ().enabled = action;
	}

	public void sure(){
		GameObject.Find ("start").GetComponent<BoxCollider2D> ().enabled = false;
		surem (true);
	}

	public void Click(){
		UserController.username = "";
		SceneManager.LoadScene ("login");
	}

	void OnMouseDown(){
		if (this.name == "wrong") {
			surem (false);
			GameObject.Find ("start").GetComponent<BoxCollider2D> ().enabled = true;
		} else if (this.name == "check") {
			Click ();
		}
	}
}
