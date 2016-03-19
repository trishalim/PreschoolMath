using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Check : MonoBehaviour {
	public static int num = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void check(){
		if (num <= GameProper.length) {
			Debug.Log (this.name);
			Debug.Log (GameProper.seq[num]);
			if (this.name == "btn" + GameProper.seq[num]) {
				num++;
				Debug.Log (num);
			}
			if (num == GameProper.length) {
				Score.score++;
				GameObject.Find ("scores").GetComponent<Text> ().text = Score.score.ToString ();
				SceneManager.LoadScene ("game");
			}
		}
	}
}
