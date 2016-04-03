using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextColor : MonoBehaviour {
	public static GameObject gameOb, gameObNum,colorPart;
	public static string num;
	public static Sprite spr;
	public GameObject colorParticle;
	public static int lev;
	// Use this for initialization
	void Start () {
		colorPart = colorParticle;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public static void changeColor(string number){
		int xndx;
		lev = GameObject.Find ("Player").GetComponent<PlayerController> ().level;
		TextColor tc = new TextColor ();
		num = "n" + PlayerController.currentNum;
		xndx = PlayerController.currentNum % 10;
		xndx = (xndx == 0) ? 10 : xndx;
		if (number == num) {
			GameObject.Find("Player").GetComponent<AudioSource> ().Play ();
			gameOb = GameObject.Find("h" + xndx.ToString());
			gameOb.GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load(number, typeof(Sprite)) as Sprite;
			//Instantiate (colorPart, gameOb.transform.position, gameOb.transform.rotation);
			if (PlayerController.currentNum == PlayerController.target) {
				Congrats.score = PlayerController.lives * 2;
				tc.score();
				SceneManager.LoadScene ("congrats");
			}
			PlayerController.currentNum++;
		}
		else {
			if(PlayerController.lives > 1){
				GameObject.Find("heart1").GetComponent<AudioSource> ().Play ();
				gameOb = GameObject.Find("heart" + PlayerController.lives);
				spr = (Sprite)Resources.Load ("hud_heartEmpty", typeof(Sprite)) as Sprite;
				gameOb.GetComponent<SpriteRenderer> ().sprite = spr;
				//Instantiate (colorPart, gameOb.transform.position, gameOb.transform.rotation);
				PlayerController.lives--;
			}
			else {
				int lev2 = GameObject.Find ("Player").GetComponent<PlayerController> ().level;
				Congrats.score = PlayerController.lives * 2;
				tc.score();
				SceneManager.LoadScene ("congrats");
			}
		}
	}

	public void score(){
		Debug.Log (lev);
		Debug.Log (Congrats.score);
		GameObject.Find("script").GetComponent<GameScore>().addScore (2, lev, Congrats.score);
	}
}