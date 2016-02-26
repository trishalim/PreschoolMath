using UnityEngine;
using System.Collections;

public class Duplicate : MonoBehaviour {
	public GameObject duplground;
	public static float posx;
	// Use this for initialization
	void Start () {
		posx = GameObject.Find("GroundLast").transform.position.x + 60.0f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnBecameInvisible(){
		Instantiate (duplground, new Vector3 (posx, (-1.432954f), 0), gameObject.transform.rotation);
		posx += 30.0f;
	}
}
