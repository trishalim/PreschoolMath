using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Life : MonoBehaviour {

	public int life;
	public Text text;
	
	void Start() {
		life = 5;
		text.text = "Life: 5";
	}
	
	public void decrementLife(){

		if(life==1){
			Debug.Log ("Game Over");
		}

		life--;
		text.text = "Life: " + life;
	}
}
