using UnityEngine;
using System.Collections;

public class LookForward : MonoBehaviour {
	public Transform sightStart, sightEnd;
	public GameObject ground;
	private bool collision = false;
	public static float posx;
	// Use this for initialization
	void Start () {
		posx = GameObject.Find("1stnum").transform.position.x + 30.0f;
	}
	
	// Update is called once per frame
	void Update () {
		collision = Physics2D.Linecast (sightStart.position, sightEnd.position, 1 << LayerMask.NameToLayer ("Number"));

		if (collision) {
			Instantiate (ground, new Vector3(posx, (-1.432954f),0), gameObject.transform.rotation);
			posx += 30.0f;
		}
	}
}
