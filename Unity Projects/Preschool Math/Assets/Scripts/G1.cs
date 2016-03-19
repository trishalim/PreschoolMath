using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class G1 : MonoBehaviour {
	public static int counter = 0;
	public static int num1;
	// Use this for initialization
	void Start () {
		PlayerController.currentgame = SceneManager.GetActiveScene ().buildIndex;
		int num = Random.Range (1, 6);
		GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load("shapes/"+ num, typeof(Sprite)) as Sprite;
		num1 = Random.Range (1, 10);
		GameObject.Find ("tap" + num.ToString ()).GetComponent<AudioSource> ().Play ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
