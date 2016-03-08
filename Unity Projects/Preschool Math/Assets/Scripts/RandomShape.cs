using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RandomShape : MonoBehaviour {
	public string namez;
	public GameScore gs;
	// Use this for initialization
	void Start () {	
		gs = new GameScore ();
		namez = "shape" + GameObject.Find ("shapetap").GetComponent<SpriteRenderer> ().sprite.name;
		int num = Random.Range (1, 6);
		GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load("shapes/shape"+ num, typeof(Sprite)) as Sprite;
		if (gameObject.name == "shape" + G1.num1) {
			GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("shapes/"+ namez, typeof(Sprite)) as Sprite;
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		G1.counter++;
		Debug.Log (G1.counter);
		if (gameObject.GetComponent<SpriteRenderer> ().sprite.name == namez) {
			GameObject.Find("tap").GetComponent<AudioSource> ().Play ();
			Congrats.score++;
			GameObject.Find (gameObject.name + "glow").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("shapes/glowc", typeof(Sprite)) as Sprite;
			GameObject.Find (gameObject.name + "check").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("check", typeof(Sprite)) as Sprite;
		} else {
			GameObject.Find("shapetap").GetComponent<AudioSource> ().Play ();
			GameObject.Find(gameObject.name + "glow").GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load("shapes/gloww", typeof(Sprite)) as Sprite;
			GameObject.Find(gameObject.name + "check").GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load("wrong", typeof(Sprite)) as Sprite;
		}
		StartCoroutine(playAgain());

	}

	IEnumerator playAgain(){	
		yield return new WaitForSeconds (1);	
		if (G1.counter < 10)
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		else {
<<<<<<< HEAD
			gs.addScore (1, 1, G1.counter);
			SceneManager.LoadScene ("congrats");	
=======
			gs.addScore (1, 0, Congrats.score);
			SceneManager.LoadScene ("congrats");		
>>>>>>> 571384015fec5a0fbfeaa6fbc00f772fb43c5ba6
		}
	}
}
