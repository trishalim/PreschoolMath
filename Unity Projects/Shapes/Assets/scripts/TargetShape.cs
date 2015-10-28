using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TargetShape : MonoBehaviour {

	public int shapeId;
	public Text shapeName;

	void Start(){
		shapeId = (int)Random.Range (0, 4.9999f);
		switch (shapeId) {
		case 0: shapeName.text = "circle"; break;
		case 1: shapeName.text = "triangle"; break;
		case 2: shapeName.text = "star"; break;
		case 3: shapeName.text = "heart"; break;
		case 4: shapeName.text = "square"; break;
		}
	}

}
