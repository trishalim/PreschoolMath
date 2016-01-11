using UnityEngine;
using System.Collections;

public class Countdown : MonoBehaviour {

	void Start(){		
		StartCoroutine (boom ());
	}

	IEnumerator boom(){
		yield return new WaitForSeconds (1);
		GameObject.Find ("count").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("count2", typeof(Sprite)) as Sprite;
		yield return new WaitForSeconds (1);
		GameObject.Find ("count").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("count1", typeof(Sprite)) as Sprite;
		yield return new WaitForSeconds (1);
		GameObject.Find ("count").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("countgo", typeof(Sprite)) as Sprite;
		yield return new WaitForSeconds (1);
		DestroyObject (GameObject.Find ("count"));
		GameObject.Find ("Player").GetComponent<PlayerController> ().enabled = true;
	}
}
