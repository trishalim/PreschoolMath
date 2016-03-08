using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float jumpHeight;
	public float moveSpeed;
	public int level;
	public static int currentNum;
	public static int target;
	public static int lives = 5;
	public GameObject number;
	private Animator anim;
	public static int currentgame;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		currentNum = (level * 10) - 9;
		target = level * 10;
		RandNum ();
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) && gameObject.transform.position.y <= 0.27f) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpHeight);
		}
		anim.SetFloat ("Speed", Mathf.Abs (GetComponent<Rigidbody2D> ().velocity.x));
	}

	void RandNum(){
		int min = (level * 10) - 9;
		GameObject.Find("number1").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("n" + Random.Range (min, min + 3), typeof(Sprite)) as Sprite;
		GameObject.Find("number2").GetComponent<SpriteRenderer> ().sprite = (Sprite)Resources.Load ("n" + Random.Range (min, min + 3), typeof(Sprite)) as Sprite;
	}
}
