using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SetNumbers : MonoBehaviour {
	public static int last;
	// Use this for initialization
	void Start () {
		last = (SceneManager.GetActiveScene ().buildIndex - 1) * 10;
		for (int i = last, j = 10; i > (last - 10); i--, j--) 
			GameObject.Find ("n" + j.ToString()).GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("hollownums/h" + i.ToString(), typeof(Sprite)) as Sprite;
	}

	// Update is called once per frame
	void Update () {
	
	}
}
