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
		GameObject.Find ("inst").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("Game2/startwith1", typeof(Sprite)) as Sprite;
		yield return new WaitForSeconds (2);
		GameObject.Find ("count").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("count1", typeof(Sprite)) as Sprite;
		GameObject.Find ("inst").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("Game2/tapanywhere", typeof(Sprite)) as Sprite;
		GameObject.Find ("sfx2").GetComponent<AudioSource> ().Play ();
		yield return new WaitForSeconds (2);
		GameObject.Find ("count").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("countgo", typeof(Sprite)) as Sprite;
		GameObject.Find ("inst").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("Game2/letsstart", typeof(Sprite)) as Sprite;
		yield return new WaitForSeconds (2);
		Destroy (GameObject.Find ("count"));
		Destroy (GameObject.Find ("gray"));
		Destroy (GameObject.Find ("inst"));
		GameObject.Find ("Ground").GetComponent<GroundController> ().enabled = true;
		GameObject.Find ("Ground2").GetComponent<GroundController> ().enabled = true;
		GameObject.Find ("Player").GetComponent<PlayerController> ().enabled = true;
		GameObject.Find ("Player").GetComponent<Animator> ().enabled = true;
		GameObject.Find ("exit").GetComponent<CircleCollider2D> ().enabled = true;
	}
}
