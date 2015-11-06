using UnityEngine;
using System.Collections;

public class TextColor : MonoBehaviour {
	public static GameObject gameOb;
	public static string num;
	public static float[,] textColors;
	public static GameObject colorParticle;

	// Use this for initialization
	void Start () {
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
		textColors [3, 0] = 0.996f;
		textColors [3, 1] = 0.518f;
		textColors [3, 2] = 0.094f;
		
		//5th num
		textColors [4, 0] = 0.996f;
		textColors [4, 1] = 0.518f;
		textColors [4, 2] = 0.094f;
		
		//6th num
		textColors [5, 0] = 0.996f;
		textColors [5, 1] = 0.518f;
		textColors [5, 2] = 0.094f;
		
		//7th num
		textColors [6, 0] = 0.996f;
		textColors [6, 1] = 0.518f;
		textColors [6, 2] = 0.094f;
		
		//8th num
		textColors [7, 0] = 0.996f;
		textColors [7, 1] = 0.518f;
		textColors [7, 2] = 0.094f;
		
		//9th num
		textColors [8, 0] = 0.996f;
		textColors [8, 1] = 0.518f;
		textColors [8, 2] = 0.094f;
		
		//10th num
		textColors [9, 0] = 0.996f;
		textColors [9, 1] = 0.518f;
		textColors [9, 2] = 0.094f;
	}
	
	// Update is called once per frame
	void Update () {


	}

	public static void changeColor(string number){
		colorParticle = GameObject.Find ("NumberParticle");
		int xndx;

		num = "num" + PlayerController.currentNum;
		xndx = PlayerController.currentNum - 1;

		if (number == num) {
			gameOb = GameObject.Find(number);
			gameOb.GetComponent<GUIText> ().color = new Color(textColors[xndx, 0],textColors[xndx, 1],textColors[xndx, 2]);
			Instantiate (colorParticle, gameOb.transform.position, gameOb.transform.rotation);
			PlayerController.currentNum++;
		}
		else {
			gameOb = GameObject.Find("heart" + PlayerController.lives);
			Instantiate (colorParticle, gameOb.transform.position, gameOb.transform.rotation);
			Destroy(gameOb);
			PlayerController.lives--;
		}
	}
}
