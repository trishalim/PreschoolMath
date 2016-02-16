using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Game3Sub : MonoBehaviour {
	int[] cho = new int[11];
	GameObject sun;
	int num1, num2, fruit;
	public static int answer, anspos, repeat = 0, score = 0;
	// Use this for initialization
	void Start () {
		sun = GameObject.Find ("sun");
		num1 = Random.Range (2, 11);
		num2 = Random.Range (1, num1);
		answer = num1 - num2;
		fruit = Random.Range (2, 6);
		setFruits ();
		PlayerController.currentgame = SceneManager.GetActiveScene ().buildIndex;
		StartCoroutine(game3subt ());
	}
	
	// Update is called once per frame
	void Update () {
		sun.transform.Rotate(0, 0, 30 * Time.deltaTime);
	}

	IEnumerator game3subt(){
		GameObject.Find ("there").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("there", typeof(Sprite)) as Sprite;
		GameObject.Find ("minuend").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("ans" + num1.ToString(), typeof(Sprite)) as Sprite;
		GameObject.Find ("fruitword").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("frtwrd" + fruit.ToString(), typeof(Sprite)) as Sprite;
		yield return new WaitForSeconds (1);
		GameObject.Find ("but").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("but", typeof(Sprite)) as Sprite;
		GameObject.Find ("subtrahend").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("ans" + num2.ToString(), typeof(Sprite)) as Sprite;
		GameObject.Find ("fell").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("fell", typeof(Sprite)) as Sprite;
		yield return new WaitForSeconds (1);
		dropFruits ();
		yield return new WaitForSeconds (1);
		GameObject.Find ("how").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("how", typeof(Sprite)) as Sprite;
		yield return new WaitForSeconds (1);
		setChoices ();
	}

	void dropFruits(){
		int[] flag = new int[10];
		int ctr = 0, frtnum;
		while (ctr != num2) {
			frtnum = Random.Range (1, num1 + 1);
			if (flag [frtnum - 1] != 1) {
				flag [frtnum - 1] = 1;
				GameObject.Find ("fruit" + frtnum.ToString ()).GetComponent<CircleCollider2D> ().enabled = true;
				GameObject.Find ("fruit" + frtnum.ToString()).AddComponent<Rigidbody2D> ();
				ctr++;
			}
		}
	}

	void setFruits(){
		for(int x = 1; x <= num1; x++)
			GameObject.Find ("fruit" + x.ToString ()).GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("fruit" + fruit.ToString (), typeof(Sprite)) as Sprite;
	}

	void setChoices(){
		GameObject option;
		int[] choices = new int[3];
		bool opt;

		//for correct answer
		anspos = Random.Range (0, 3);
		choices [anspos] = answer;
		cho [answer] = 1;
		option = GameObject.Find ("ans" + anspos.ToString ());
		option.GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load ("ans" + answer.ToString(), typeof(Sprite)) as Sprite;

		//for other choices
		for (int i = 0; i < 3; i++) {
			opt = false;
			if (i != anspos) {				
				while (opt == false) {
					choices[i] = Random.Range (1, 11);
					opt = checkChoice (choices [i]);
				}
				option = GameObject.Find ("ans" + i.ToString ());
				option.GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load ("ans" + choices[i].ToString(), typeof(Sprite)) as Sprite;
			}
		}
	}

	public bool checkChoice(int num){
		return (cho [num] == 1) ? false : true;
	}
}
