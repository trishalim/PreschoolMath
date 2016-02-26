using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

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
		GameObject.Find ("pause").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("pause", typeof(Sprite)) as Sprite;
		GameObject.Find ("pausemenu").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("pausemenu", typeof(Sprite)) as Sprite;
		yield return new WaitForSeconds (0.1f);
		GameObject.Find ("resume").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("resume", typeof(Sprite)) as Sprite;
		yield return new WaitForSeconds (0.2f);
		GameObject.Find ("restart").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("restart", typeof(Sprite)) as Sprite;
		yield return new WaitForSeconds (0.2f);
		GameObject.Find ("quit").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("quit", typeof(Sprite)) as Sprite;
	}

	void resume(){
		GameObject.Find ("pause").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("", typeof(Sprite)) as Sprite;
		GameObject.Find ("pausemenu").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("", typeof(Sprite)) as Sprite;
		GameObject.Find ("resume").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("", typeof(Sprite)) as Sprite;
		GameObject.Find ("restart").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("", typeof(Sprite)) as Sprite;
		GameObject.Find ("quit").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("", typeof(Sprite)) as Sprite;
	}

	void restart(){
		SceneManager.LoadScene (PlayerController.currentgame);
	}

	void quit(){
		SceneManager.LoadScene ("submenu");
	}
}
