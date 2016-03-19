using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Exit : MonoBehaviour {

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

	public void Click(){
		Application.Quit ();
	}

	void OnMouseDown(){
		if (this.name == "wrong") {
			surem (false);
			GameObject.Find ("Sign In Button").GetComponent<Button> ().interactable = true;
		} else if (this.name == "check") {
			Click ();
		} else if (this.name == "exit") {
			GameObject.Find ("Sign In Button").GetComponent<Button> ().interactable = false;
			surem (true);
		}else if (this.name == "fruit4") {
			SceneManager.LoadScene ("mainmenu");
		}
	}
}
