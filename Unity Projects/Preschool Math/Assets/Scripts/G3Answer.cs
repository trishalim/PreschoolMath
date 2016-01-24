using UnityEngine;
using System.Collections;

public class G3Answer : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnMouseDown(){
		string name = "ans" + Game3.answer;
		Sprite spr = (Sprite)Resources.Load (gameObject.GetComponent<SpriteRenderer> ().sprite.name, typeof(Sprite)) as Sprite;
		Sprite glow, icon;
		GameObject.Find ("ans").GetComponent<SpriteRenderer> ().sprite = spr;
		if (gameObject.GetComponent<SpriteRenderer> ().sprite.name == name) {
			glow = (Sprite)Resources.Load ("glowc", typeof(Sprite)) as Sprite;
			icon = (Sprite)Resources.Load ("check", typeof(Sprite)) as Sprite;
		} else {
			glow = (Sprite)Resources.Load ("gloww", typeof(Sprite)) as Sprite;
			icon = (Sprite)Resources.Load ("wrong", typeof(Sprite)) as Sprite;
		}
		GameObject.Find ("glow").GetComponent<SpriteRenderer> ().sprite = glow;	
		GameObject.Find ("icon").GetComponent<SpriteRenderer> ().sprite = icon;	
	}
}
