using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	public int score;
	public Text text;

	void Start() {
		score = 0;
		text.text = "Score: 0";
	}

	public void incrementScore(){
		score++;
		text.text = "Score: " + score;
	}

}
