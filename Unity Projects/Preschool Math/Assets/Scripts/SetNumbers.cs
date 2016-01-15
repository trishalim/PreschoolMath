using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SetNumbers : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int last = SceneManager.GetActiveScene ().buildIndex * 10;
		GameObject obj;
		for (int i = last, j = 10; i > (last - 10); i--, j--) {
			obj = GameObject.Find("num" + j.ToString());
			obj.GetComponent<Text> ().text = i.ToString ();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
