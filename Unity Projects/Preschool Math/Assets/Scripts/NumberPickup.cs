using UnityEngine;
using System.Collections;

public class NumberPickup : MonoBehaviour {

	public GameObject numberParticle, number, ground;

	void OnTriggerEnter2D (Collider2D other)
	{
		float posx = gameObject.transform.position.x + 15.0f;
		if (other.GetComponent<PlayerController> () == null)
			return;
		Instantiate (number, new Vector3(posx, 0,0), gameObject.transform.rotation);
		Instantiate (ground, new Vector3(posx, (-1.432954f),0), gameObject.transform.rotation);
		Instantiate (numberParticle, gameObject.transform.position, gameObject.transform.rotation);
		TextColor.changeColor(gameObject.GetComponent<SpriteRenderer> ().sprite.name);
		Destroy (gameObject);
	}
}
