using UnityEngine;
using System.Collections;

public class NumberPickup : MonoBehaviour {

	public GameObject numberParticle;
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.GetComponent<PlayerController> () == null)
			return;
		Instantiate (numberParticle, gameObject.transform.position, gameObject.transform.rotation);
		TextColor.changeColor(gameObject.GetComponent<SpriteRenderer> ().sprite.name);
		Destroy (gameObject);
	}
}
