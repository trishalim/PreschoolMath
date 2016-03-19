using UnityEngine;
using System.Collections;

public class Congrats : MonoBehaviour {
	public static int score = 0;
	GameObject glow, glow2;
	// Use this for initialization
	void Start () {
		glow = GameObject.Find ("glowcong");
		glow2 = GameObject.Find ("glowcong2");
		Game3Sub.repeat = 0;
		G1.counter = 0;
		StartCoroutine (congrats ());
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		glow.transform.Rotate(0, 0, 30 * Time.deltaTime);
		glow2.transform.Rotate(0, 0, -30 * Time.deltaTime);
	}

	IEnumerator congrats(){
		GameObject.Find ("score").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("n" + score, typeof(Sprite)) as Sprite;
		int i = score/2;
		if (score % 2 != 0)
			i += 1;
		GameObject.Find ("sfx" + i.ToString ()).GetComponent<AudioSource> ().Play ();
		switch (i) {
			case 5:
				GameObject.Find ("congmsg").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("congam", typeof(Sprite)) as Sprite;
				break;
			case 4:
				GameObject.Find ("congmsg").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("congex", typeof(Sprite)) as Sprite;
				break;
			case 3:
				GameObject.Find ("bgcong").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("bgcong1", typeof(Sprite)) as Sprite;
				GameObject.Find ("congmsg").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("conggreat", typeof(Sprite)) as Sprite;
				break;
			case 2:
				GameObject.Find ("bgcong").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("bgcong1", typeof(Sprite)) as Sprite;
				GameObject.Find ("congmsg").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("congbet", typeof(Sprite)) as Sprite;
				break;
			case 1:
			default:
				GameObject.Find ("bgcong").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("bgcong2", typeof(Sprite)) as Sprite;
				GameObject.Find ("congmsg").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("congtry", typeof(Sprite)) as Sprite;
				break;
		}
		for (int j = 1; j <= i; j++) {
			yield return new WaitForSeconds (0.5f);
			GameObject.Find ("star" + j.ToString()).GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("star", typeof(Sprite)) as Sprite;
		}
		score = 0;
	}
}
