using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Game3 : MonoBehaviour {
	int[] cho = new int[11];
	public static int answer;
	// Use this for initialization
	void Start () {
		PlayerController.currentgame = SceneManager.GetActiveScene ().buildIndex;
		setDigits ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setDigits(){
		GameObject digit, digit2;
		int frt1 = Random.Range (1, 6);
		int frt2 = Random.Range (1, 6);
		Sprite fruit1 = (Sprite)Resources.Load ("fruit" + frt1.ToString(), typeof(Sprite)) as Sprite;
		Sprite fruit2 = (Sprite)Resources.Load ("fruit" + frt2.ToString(), typeof(Sprite)) as Sprite;
		int numF, numS, i, j;
		numF = Random.Range (1, 6);
		numS = Random.Range (1, 6);

		for (i = 1; i <= numF; i++) {
			digit = GameObject.Find ("digit1" + i.ToString());
			digit.GetComponent<SpriteRenderer> ().sprite = fruit1;
		}

		for (j = 1; j <= numS; j++) {
			digit2 = GameObject.Find ("digit2" + j.ToString());
			digit2.GetComponent<SpriteRenderer> ().sprite = fruit2;
		}
		answer = numF + numS;
		setChoices (answer);
	}

	public void setChoices(int ans){
		GameObject option;
		int[] choices = new int[3];
		bool opt;

		//for correct answer
		int anspos = Random.Range (0, 3);
		choices [anspos] = ans;
		cho [ans] = 1;
		option = GameObject.Find ("choice" + anspos.ToString ());
		option.GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load ("ans" + ans.ToString(), typeof(Sprite)) as Sprite;

		//for other choices
		for (int i = 0; i < 3; i++) {
			opt = false;
			if (i != anspos) {				
				while (opt == false) {
					choices[i] = Random.Range (1, 11);
					opt = checkChoice (choices [i]);
				}
				option = GameObject.Find ("choice" + i.ToString ());
				option.GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load ("ans" + choices[i].ToString(), typeof(Sprite)) as Sprite;
			}
		}
	}

	public bool checkChoice(int num){
		return (cho [num] == 1) ? false : true;
	}

	public void quit(){
		Debug.Log ("bye");
	}
}
