using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogOut : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Button>().onClick.AddListener(() => Click());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Click(){
		UserController.username = "";
		SceneManager.LoadScene ("login");
	}
}
