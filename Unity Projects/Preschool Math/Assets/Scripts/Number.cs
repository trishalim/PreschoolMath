using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Number : MonoBehaviour {

	public Sprite numSpr;
	public GameObject ground;
	public static float posx;
	public static int[] numbersUsed;
	public int i, x;

	void Start () {
		SetRandomNumber();
		posx = GameObject.Find("1stnum").transform.position.x + 30.0f;
		x = 0;
	}

	void SetNumber(Sprite number){
		this.GetComponent<SpriteRenderer> ().sprite = number;
	}

	void SetRandomNumber(){
		SetNumber (GetRandomNumber ());
	}

	Sprite GetRandomNumber(){
		int max = 10 * SceneManager.GetActiveScene().buildIndex;
		int min = PlayerController.currentNum;
		int numberId = Random.Range (min, max + 1);
		numSpr = (Sprite)Resources.Load ("n" + numberId, typeof(Sprite)) as Sprite;
		return numSpr;
	}

	void OnBecameVisible(){

	}
}
