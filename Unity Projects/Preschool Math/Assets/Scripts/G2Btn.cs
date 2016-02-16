﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class G2Btn : MonoBehaviour {
	public int game;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		string scene = "";
		switch (game) {
		case 2:
			scene = "game2levels";
			break;
		case 3:
			scene = "game3sub";
			break;
		case 4:
			scene = "submenu";
			break;
		case 5:
			scene = "game3";
			break;
		case 6:
			scene = "sub";
			break;
		default:
			scene = "";
			break;
		}	
		SceneManager.LoadScene (scene);
	}
}