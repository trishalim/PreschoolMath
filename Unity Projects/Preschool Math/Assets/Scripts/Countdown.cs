using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour {

	void Start(){		
		StartCoroutine (boom ());
	}

	IEnumerator boom(){
		yield return new WaitForSeconds (2);
		GameObject.Find ("count").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("count2", typeof(Sprite)) as Sprite;
		GameObject.Find ("inst").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("Game2/startwith" + (SetNumbers.last - 9), typeof(Sprite)) as Sprite;
		yield return new WaitForSeconds (2);
		GameObject.Find ("count").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("count1", typeof(Sprite)) as Sprite;
		GameObject.Find ("inst").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("Game2/tapanywhere", typeof(Sprite)) as Sprite;
		yield return new WaitForSeconds (2);
		GameObject.Find ("count").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("countgo", typeof(Sprite)) as Sprite;
		GameObject.Find ("inst").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("Game2/letsstart", typeof(Sprite)) as Sprite;
		yield return new WaitForSeconds (2);
		DestroyObject (GameObject.Find ("count"));
		DestroyObject (GameObject.Find ("inst"));
		GameObject.Find ("Player").GetComponent<PlayerController> ().enabled = true;
	}
}
