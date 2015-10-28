using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShapeBehavior : MonoBehaviour {

	public GameObject score;
	public GameObject lives;

	void Start() {
		score = GameObject.Find ("Score");
		lives = GameObject.Find ("Life");
	}

	void OnMouseDown(){
		Destroy (gameObject);
		GameObject targetShape = GameObject.Find ("TargetShape");
		TargetShape targetShapeScript = (TargetShape) targetShape.GetComponent(typeof(TargetShape));
		string shapeName = transform.name.Replace ("(Clone)", "");
		Debug.Log (targetShapeScript.shapeName.text.ToString ());
		if (shapeName == targetShapeScript.shapeName.text.ToString()) {
			Score scoreScript = (Score) score.GetComponent(typeof(Score));
			scoreScript.incrementScore ();
		}
		else {
			Debug.Log ("Life");
			Lives livesScript = (Lives) lives.GetComponent(typeof(Lives));
			if(livesScript!=null){
				livesScript.decrementLives();
				Debug.Log (livesScript.count);
			}
		}
	}
}
