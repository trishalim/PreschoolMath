using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	GameObject cir;
	// Use this for initialization
	void Start () {
		cir = GameObject.Find ("rot");
	}
	
	// Update is called once per frame
	void Update () {
		cir.transform.Rotate(0, 0, 30 * Time.deltaTime);
	}
}
