using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Number : MonoBehaviour {

	public Sprite numSpr;

	public static int[] numbersUsed;
	public int i;

	void Start () {
		SetRandomNumber();
	}

	void SetNumber(Sprite number){
		this.GetComponent<SpriteRenderer> ().sprite = number;
	}

	void SetRandomNumber(){
		SetNumber (GetRandomNumber ());
	}

	Sprite GetRandomNumber(){
		int max = 10 * SceneManager.GetActiveScene().buildIndex;
		int min = max - 9;
		int numberId = Random.Range (min, max + 1);
		numSpr = (Sprite)Resources.Load ("num" + numberId, typeof(Sprite)) as Sprite;
		return numSpr;
	}

}
