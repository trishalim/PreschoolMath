using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameProper : MonoBehaviour {
	public static int[] seq = new int[10];
	public static int length = 4;
	// Use this for initialization
	void Start () {
		Check.num = 0;
		Debug.Log ("num = " + Check.num);
		GameObject.Find ("scores").GetComponent<Text> ().text = Score.score.ToString();
		StartCoroutine (playgame ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator playgame(){
		int bgnum, symnum;

		for (int i = 0; i < 4; i++) {
			bgnum = Random.Range (1, 6);
			symnum = Random.Range (1, 5);
			seq [i] = symnum;
			GameObject.Find ("1bg").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("bgcolors/" + bgnum + "bg", typeof(Sprite)) as Sprite;
			GameObject.Find ("1h").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load (symnum + "h", typeof(Sprite)) as Sprite;
			yield return new WaitForSeconds (1.5f);
		}
		GameObject.Find ("1bg").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("", typeof(Sprite)) as Sprite;
		GameObject.Find ("1h").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("", typeof(Sprite)) as Sprite;

		yield return new WaitForSeconds (0.5f);
		for (int i = 1; i < 5; i++) {
			GameObject.Find ("btn" + i).GetComponent<Button> ().interactable = true;
		}
	}
}
