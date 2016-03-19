using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class G3SubAns : MonoBehaviour {
	public int pos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		string name = gameObject.GetComponent<SpriteRenderer> ().sprite.name;
		string mark;
		if (name == "ans" + Game3Sub.answer.ToString ()) {
			mark = "check";
			Game3Sub.score++;
			Congrats.score++;
		}
		else
			mark = "wrong";
		GameObject.Find ("ans" + pos + "mark").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load (mark, typeof(Sprite)) as Sprite;
		Game3Sub.repeat++;
		if (Game3Sub.repeat < 10)
			StartCoroutine (playAgain ());
		else {
			Game3Sub.repeat = 0;
			addScore (3, 2, Congrats.score *10);
			SceneManager.LoadScene ("congrats");
		}
	}

	IEnumerator playAgain(){		
		yield return new WaitForSeconds (2);
		SceneManager.LoadScene ("sub");
	}

	public void addScore(int game_id, int level, int score) {
		WWWForm form = new WWWForm();
		form.AddField("game_id", game_id);
		form.AddField("level", level);
		form.AddField("score", score);
		form.AddField("username", UserController.username);
		WWW w = new WWW (Url.url + "/unity/add_score.php", form);
		StartCoroutine (Call (w));
	}

	IEnumerator Call (WWW w){
		yield return w;
		Debug.Log ("call");
		Debug.Log (w.text);
	}
}
