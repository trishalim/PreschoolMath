using UnityEngine;
using System.Collections;

public class DuplicateGround : MonoBehaviour {

	//public GameObject ground;
	//public GameObject number;
	//private PlayerController player;
	//public static float posxn;
	public static GameObject playerr;
	//public static float posxg;
	//public static int curr;
	//private int i = 0;
	void Start(){
		playerr = GameObject.Find ("Player");
	}

	void Update(){
		if (playerr.transform.position.x == 1) {
			Debug.Log ("OH YEAH");
		}
	}
	/*
	void Duplicate(){
		Debug.Log ("currnum " + Number.currentNum);
		Debug.Log ("curr " + curr);
			Instantiate(gameObject, new Vector3(posxn, gameObject.transform.position.y, 0), gameObject.transform.rotation);
			curr ++;
			Debug.Log ("yey");

		Debug.Log ("postcurr " + curr);
	}*/
}