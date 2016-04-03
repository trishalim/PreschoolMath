using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	public static int score = 0;
	public static int highscore;
	// Use this for initialization
	void Start () {
		highscore = PlayerPrefs.GetInt ("HS");
	}
	
	// Update is called once per frame
	void Update () {
		if (highscore < score) {
			highscore = score;
			PlayerPrefs.SetInt ("HS", highscore);
		}
	}
}
