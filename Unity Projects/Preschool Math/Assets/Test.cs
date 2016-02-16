using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject set1 = new GameObject();
		set1.transform.position = guiLocation(1);
		set1.AddComponent<GUIText>();
		set1.guiText = "Sensitivity";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
