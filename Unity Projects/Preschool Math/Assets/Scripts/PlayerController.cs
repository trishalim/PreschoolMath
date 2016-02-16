using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float jumpHeight;
	public float moveSpeed;
	public static int currentNum = 1;
	public static int target = 10;
	public static int lives = 5;
	public GameObject number;
	private Animator anim;
	public static int currentgame;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) && gameObject.transform.position.y <= 0.27f) {

			//GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5000));
			//GetComponent<Rigidbody2D>().AddForce (transform.up * 34000);
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jumpHeight);
		}
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y);
			//GetComponent<Rigidbody2D> ().velocity = new Vector2 (transform.localScale.x, 0) * moveSpeed;
		anim.SetFloat ("Speed", Mathf.Abs (GetComponent<Rigidbody2D> ().velocity.x));
	}
}
