﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class G3Answer : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnMouseDown(){
		string name = "ans" + Game3.answer;
		Sprite spr = (Sprite)Resources.Load (gameObject.GetComponent<SpriteRenderer> ().sprite.name, typeof(Sprite)) as Sprite;
		Sprite glow, icon;
		GameObject.Find ("ans").GetComponent<SpriteRenderer> ().sprite = spr;
		if (gameObject.GetComponent<SpriteRenderer> ().sprite.name == name) {
			GameObject.Find ("choicebg").GetComponent<AudioSource> ().Play ();
			glow = (Sprite)Resources.Load ("glowc", typeof(Sprite)) as Sprite;
			icon = (Sprite)Resources.Load ("check", typeof(Sprite)) as Sprite;
			Game3Sub.score++;
			Congrats.score++;
		} else {
			GameObject.Find ("choicebg1").GetComponent<AudioSource> ().Play ();
			glow = (Sprite)Resources.Load ("gloww", typeof(Sprite)) as Sprite;
			icon = (Sprite)Resources.Load ("wrong", typeof(Sprite)) as Sprite;
		}
		GameObject.Find ("glow").GetComponent<SpriteRenderer> ().sprite = glow;	
		GameObject.Find ("icon").GetComponent<SpriteRenderer> ().sprite = icon;	
		Game3Sub.repeat++;
		if (Game3Sub.repeat < 10)
			StartCoroutine (playAgain ());
		else {
			Game3Sub.repeat = 0;
			addScore (3, 1, Congrats.score);
			SceneManager.LoadScene ("congrats");
		}
	}

	IEnumerator playAgain(){		
		yield return new WaitForSeconds (1);
		SceneManager.LoadScene ("game3");
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
