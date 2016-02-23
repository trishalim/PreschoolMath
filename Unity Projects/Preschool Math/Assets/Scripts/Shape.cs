using UnityEngine;
using System.Collections;

public class Shape : MonoBehaviour {

	public Sprite[] shapeSprites;
	public int hitCount;
	public int shapeId;

	void Start () {
		hitCount = 0;
		shapeSprites = new Sprite[5];
		shapeSprites [0] = (Sprite)Resources.Load ("sprites/circle", typeof(Sprite)) as Sprite;
		shapeSprites [1] = (Sprite)Resources.Load ("sprites/heart", typeof(Sprite)) as Sprite;
		shapeSprites [2] = (Sprite)Resources.Load ("sprites/star", typeof(Sprite)) as Sprite;
		shapeSprites [3] = (Sprite)Resources.Load ("sprites/triangle", typeof(Sprite)) as Sprite;
		shapeSprites [4] = (Sprite)Resources.Load ("sprites/square", typeof(Sprite)) as Sprite;
		StartCoroutine(UpdateShape());
	}

	IEnumerator UpdateShape()
	{
		while(true)
		{
			SetRandomShape ();
			int seconds = Random.Range (2, 4);
			yield return new WaitForSeconds(seconds);
		}
	}
	
	void SetShape(Sprite shape){
		this.GetComponent<SpriteRenderer> ().sprite = shape;
	}

	void SetRandomShape(){
		SetShape (GetRandomShape ());
	}

	Sprite GetRandomShape(){
		int shapeId = (int)Random.Range (0, 4.9999f);
		return shapeSprites[shapeId];
	}

	void Update(){
		if (Input.touchCount == 1) {
			Destroy(GameObject.Find("shape"+shapeId));
		}
		if(Input.GetMouseButtonDown(0)){
			Debug.Log (shapeId);
			Destroy(GameObject.Find("shape3"));

		}
	}

}
