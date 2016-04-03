using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameProper : MonoBehaviour {
	public static int[] seq = new int[10];
	public static int length = 3;
	public static int repeat = 0;
	public static float time = 1.5f;
	// Use this for initialization
	void Start () {
		Check.num = 0;
		repeat++;
		if (repeat % 15 == 0 && time != 0.3f)
			time -= 0.2f;
		if (repeat % 10 == 0)
			length++;
		GameObject.Find ("scores").GetComponent<Text> ().text = Score.score.ToString();
		GameObject.Find ("best").GetComponent<Text> ().text = Score.highscore.ToString();
		StartCoroutine (playgame ());
	}
	
	// Update is called once per frame
	void Update () {			
	
	}

	IEnumerator playgame(){
		int bgnum, symnum;
		Debug.Log (length);
		for (int i = 0; i < length; i++) {
			bgnum = Random.Range (1, 6);
			symnum = Random.Range (1, 5);
			seq [i] = symnum;
			GameObject.Find ("1bg").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("bgcolors/" + bgnum + "bg", typeof(Sprite)) as Sprite;
			GameObject.Find ("1h").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load (symnum + "h", typeof(Sprite)) as Sprite;
			GameObject.Find ("rep" + symnum.ToString()).GetComponent<AudioSource> ().Play();
			yield return new WaitForSeconds (time);
			Debug.Log ("hehe" + i + " " + length);
			GameObject.Find ("1bg").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("", typeof(Sprite)) as Sprite;
			GameObject.Find ("1h").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("", typeof(Sprite)) as Sprite;
			yield return new WaitForSeconds (0.1f);
		}
		GameObject.Find ("1bg").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("", typeof(Sprite)) as Sprite;
		GameObject.Find ("1h").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("", typeof(Sprite)) as Sprite;

		for (int i = 1; i < 5; i++) {
			GameObject.Find ("btn" + i).GetComponent<Button> ().interactable = true;
		}
	}
}
