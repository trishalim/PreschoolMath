using UnityEngine;
using System.Collections;

public class Star : MonoBehaviour {

	public int level;

	void Start () {
		getNumStars ();
	}

	void getNumStars() {
		WWWForm form = new WWWForm();
		form.AddField ("level", level);
		//form.AddField("user", "palsmiley");
		form.AddField("user", UserController.username);
		//WWW w = new WWW ("localhost/preschoolmath/unity/getnumstars.php", form);
		WWW w = new WWW (Url.url + "/unity/getnumstars.php", form);
		StartCoroutine (Call(w));	
	}

	IEnumerator Call (WWW w){
		yield return w;
		Debug.Log (w.text);
		int star = numStars (int.Parse (w.text));
		gameObject.GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load("stars/"+ star.ToString(), typeof(Sprite)) as Sprite;
	}

	int numStars(int s){
		int ret = s / 2;
		if (s % 2 != 0)
			ret += 1;
		return ret;
	}
}
