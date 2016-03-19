using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SignUpLink : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//GetComponent<Text>().onClick.AddListener(() => Click());
		//GetComponent<Text>().
		GUI.backgroundColor = Color.clear;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		Debug.Log ("MOUSEOWN");
	}


}
