using UnityEngine;
using System.Collections;

public class NumberPickup : MonoBehaviour {
	public GameObject numberParticle;

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			Instantiate (numberParticle, gameObject.transform.position, gameObject.transform.rotation);
			TextColor.changeColor (gameObject.GetComponent<SpriteRenderer> ().sprite.name);
			GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("", typeof(Sprite)) as Sprite;
			GetComponent<BoxCollider2D> ().enabled = false;
		}
	}
}
