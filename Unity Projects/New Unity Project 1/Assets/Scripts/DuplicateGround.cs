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
	private int i, pos;
	void Start(){
		playerr = GameObject.Find ("Player");
		i = 1;
		pos = 13;
	}

	void Update(){
		Debug.Log("i b4 " + i);
		Debug.Log("pos b4 " + pos);
		if (playerr.transform.position.x > pos) {
			Dup();
		}
	}

	void Dup(){
		Debug.Log("i sud " + i);
		Debug.Log("pos sud " + pos);
		i++;
		pos = 13 * i;
		Debug.Log("i " + i);
		Debug.Log("pos " + pos);
		Instantiate(gameObject, new Vector3(gameObject.transform.position.x + 15, gameObject.transform.position.y, 0), gameObject.transform.rotation);
	}
}