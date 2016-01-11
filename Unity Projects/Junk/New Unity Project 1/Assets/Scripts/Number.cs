using UnityEngine;
using System.Collections;

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
		int max = 10 * Application.loadedLevel;
		int min = max - 9;
		int numberId = Random.Range (min, max);
		numSpr = (Sprite)Resources.Load ("num" + numberId, typeof(Sprite)) as Sprite;
		return numSpr;
	}

}
