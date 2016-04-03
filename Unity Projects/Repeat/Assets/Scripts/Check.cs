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
		GameObject.Find ("rep" + GameProper.seq [num]).GetComponent<AudioSource> ().Play();
		if (num <= GameProper.length) {
			if (this.name == "btn" + GameProper.seq [num]) {
				num++;
			} else 
				SceneManager.LoadScene ("gameover");
		
			if (num == GameProper.length) {
				Score.score++;
				GameObject.Find ("scores").GetComponent<Text> ().text = Score.score.ToString ();
				StartCoroutine (correct ());
			}
		}
	}

	IEnumerator correct(){
		yield return new WaitForSeconds (0.3f);
		GameObject.Find ("correct").GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (1.2f);
		SceneManager.LoadScene ("game");
	}
}
