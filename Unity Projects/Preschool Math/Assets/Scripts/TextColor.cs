using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TextColor : MonoBehaviour {
	public static GameObject gameOb, gameObNum,colorPart;
	public static string num;
	public static float[,] textColors;
	public static Sprite spr;
	public GameObject colorParticle;

	// Use this for initialization
	void Start () {
		colorPart = colorParticle;
	}
	
	// Update is called once per frame
	void Update () {


	}

	public static void changeColor(string number){
		int xndx;

		num = "n" + PlayerController.currentNum;
		xndx = PlayerController.currentNum % 10;

		if (number == num) {
			gameOb = GameObject.Find("n" + xndx.ToString());
			gameOb.GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load(number, typeof(Sprite)) as Sprite;
			Instantiate (colorPart, gameOb.transform.position, gameOb.transform.rotation);
			if (PlayerController.currentNum == PlayerController.target) {
				PlayerController.target += 10;
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			}
			PlayerController.currentNum++;
		}
		else {
			if(PlayerController.lives > 0){
				gameOb = GameObject.Find("heart" + PlayerController.lives);
				spr = (Sprite)Resources.Load ("hud_heartEmpty", typeof(Sprite)) as Sprite;
				gameOb.GetComponent<SpriteRenderer> ().sprite = spr;
				Instantiate (colorPart, new Vector3(gameOb.transform.position.x, gameOb.transform.position.y, 0), gameOb.transform.rotation);
				PlayerController.lives--;
			}
			else {
				Congrats.score = PlayerController.lives * 2;
				SceneManager.LoadScene ("congrats");
			}
		}
	}
}
