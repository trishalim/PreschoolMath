using UnityEngine;
using System.Collections;

public class Game3 : MonoBehaviour {
	int[] cho = new int[11];
	// Use this for initialization
	void Start () {
		setDigits ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setDigits(){
		GameObject digit;
		Sprite fruit = (Sprite)Resources.Load ("cherry", typeof(Sprite)) as Sprite;
		int numF, numS, i, j;
		numF = Random.Range (1, 5);
		numS = Random.Range (1, 5);

		for (i = 1; i <= numF; i++) {
			digit = GameObject.Find ("digit1" + i.ToString());
			digit.GetComponent<SpriteRenderer> ().sprite = fruit;
		}

		for (j = 1; j <= numS; j++) {
			digit = GameObject.Find ("digit2" + j.ToString());
			//digit.GetComponent<SpriteRenderer> ().sprite = fruit;
		}

		setChoices (numF + numS);
	}

	public void setChoices(int ans){
		Debug.Log ("answer: " + ans);
		GameObject option;
		int[] choices = new int[3];
		bool opt;

		//for correct answer
		int anspos = Random.Range (1, 2);
		choices [anspos] = ans;
		cho [ans] = 1;
		option = GameObject.Find ("choice" + anspos.ToString ());
		option.GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load ("ans" + ans.ToString(), typeof(Sprite)) as Sprite;

		//for other choices
		for (int i = 0; i < 3; i++) {
			opt = false;
			if (i != anspos) {				
				while (opt == false) {
					choices[i] = Random.Range (0, 10);
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
}
