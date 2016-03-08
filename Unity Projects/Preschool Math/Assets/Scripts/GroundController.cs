using UnityEngine;
using System.Collections;

public class GroundController : MonoBehaviour {
	public int num;
	public float backGroundMoveRate = .07f;
	// Use this for initialization
	void Start()
	{
	}
	// Update is called once per frame
	void Update()
	{
	}
	void FixedUpdate()
	{
		//moves the background according to the background speed
		transform.position = new Vector2(
			transform.position.x - backGroundMoveRate,
			transform.position.y);
		//checks if the bacground is in end position
		if (transform.position.x <= -20f) {
			//move this object to the starting position
			transform.position = new Vector2(20f, transform.position.y);
			int min = PlayerController.currentNum;
			int max = (min <= ((SetNumbers.lev * 10) - 2)) ? min + 3 : (SetNumbers.lev * 10) + 1;
			GameObject.Find("number" + num.ToString()).GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load ("n" + Random.Range(min, max), typeof(Sprite)) as Sprite;
			GameObject.Find("number" + num.ToString()).GetComponent<BoxCollider2D> ().enabled = true;
		}
	}
}