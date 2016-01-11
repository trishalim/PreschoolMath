using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TextColor : MonoBehaviour {
	public static GameObject gameOb, gameObNum,colorPart;
	public static string num;
	public static float[,] textColors;
	public static Sprite spr;
	public GameObject colorParticle;

	// Use this for initialization
	void Start () {
		colorPart = colorParticle;
		textColors = new float[10, 3];

		//1st num
		textColors [0, 0] = 1;
		textColors [0, 1] = 0.262f;
		textColors [0, 2] = 0.211f;

		//2nd num
		textColors [1, 0] = 0.996f;
		textColors [1, 1] = 0.518f;
		textColors [1, 2] = 0.094f;

		//3rd num
		textColors [2, 0] = 0.996f;
		textColors [2, 1] = 0.922f;
		textColors [2, 2] = 0.094f;

		//4th num
		textColors [3, 0] = 0.2f;
		textColors [3, 1] = 0.8f;
		textColors [3, 2] = 0.2f;
		
		//5th num
		textColors [4, 0] = 0.054f;
		textColors [4, 1] = 0.713f;
		textColors [4, 2] = 0.561f;
		
		//6th num
		textColors [5, 0] = 0;
		textColors [5, 1] = 0.502f;
		textColors [5, 2] = 1;
		
		//7th num
		textColors [6, 0] = 0;
		textColors [6, 1] = 0;
		textColors [6, 2] = 0.659f;
		
		//8th num
		textColors [7, 0] = 0.569f;
		textColors [7, 1] = 0;
		textColors [7, 2] = 0.482f;
		
		//9th num
		textColors [8, 0] = 0.819f;
		textColors [8, 1] = 0.004f;
		textColors [8, 2] = 0.517f;
		
		//10th num
		textColors [9, 0] = 1;
		textColors [9, 1] = 0.502f;
		textColors [9, 2] = 0.753f;
	}
	
	// Update is called once per frame
	void Update () {


	}

	public static void changeColor(string number){
		int xndx;

		num = "num" + PlayerController.currentNum;
		xndx = (PlayerController.currentNum % 10) - 1;

		if (number == num) {
			gameOb = GameObject.Find(number);
			gameOb.GetComponent<GUIText> ().color = new Color(textColors[xndx, 0],textColors[xndx, 1],textColors[xndx, 2]);
			Instantiate (colorPart, gameOb.transform.position, gameOb.transform.rotation);
			PlayerController.currentNum++;
			if (PlayerController.currentNum == PlayerController.target) {
				PlayerController.target += 10;
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			}
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
				Debug.Log("GAME OVER!");
			}
		}
	}
}
