using UnityEngine;
using System.Collections;

public class LifeState : MonoBehaviour {
	public int lifeNum;

	// Use this for initialization
	void Start () {
		if (lifeNum > PlayerController.lives) {
			gameObject.GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("hud_heartEmpty", typeof(Sprite)) as Sprite;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
