using UnityEngine;
using System.Collections;

public class GameScore : MonoBehaviour {

	void Start() {
		Debug.Log ("start");
		//addScore (1, 1, 100);
	}

	public void addScore(int game_id, int level, int score) {
		WWWForm form = new WWWForm();
		form.AddField("game_id", game_id);
		form.AddField("level", level);
		form.AddField("score", score);
		form.AddField("username", UserController.username);
		WWW w = new WWW (Url.url + "/unity/add_score.php", form);
		//WWW w = new WWW("http://preschoolmath.x10host.com/unity/add_score.php", form);
		StartCoroutine (Call (w));
	}

	IEnumerator Call (WWW w){
		yield return w;
		Debug.Log ("call");
		Debug.Log (w.text);
	}
}
