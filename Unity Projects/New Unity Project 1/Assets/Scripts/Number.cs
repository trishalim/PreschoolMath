using UnityEngine;
using System.Collections;

public class Number : MonoBehaviour {

	public Sprite[] numberSprites;

	public static int[] numbersUsed;
	public int i;

	void Start () {
		numbersUsed = new int[10];
		numberSprites = new Sprite[10];
		for (i = 0; i < 10; i++) {
			numbersUsed [i] = 0;
		}

		numberSprites [0] = (Sprite)Resources.Load ("num1", typeof(Sprite)) as Sprite;
		numberSprites [1] = (Sprite)Resources.Load ("num2", typeof(Sprite)) as Sprite;
		numberSprites [2] = (Sprite)Resources.Load ("num3", typeof(Sprite)) as Sprite;
		numberSprites [3] = (Sprite)Resources.Load ("num4", typeof(Sprite)) as Sprite;
		numberSprites [4] = (Sprite)Resources.Load ("num5", typeof(Sprite)) as Sprite;
		numberSprites [5] = (Sprite)Resources.Load ("num6", typeof(Sprite)) as Sprite;
		numberSprites [6] = (Sprite)Resources.Load ("num7", typeof(Sprite)) as Sprite;
		numberSprites [7] = (Sprite)Resources.Load ("num8", typeof(Sprite)) as Sprite;
		numberSprites [8] = (Sprite)Resources.Load ("num9", typeof(Sprite)) as Sprite;
		numberSprites [9] = (Sprite)Resources.Load ("num10", typeof(Sprite)) as Sprite;
		SetRandomNumber();
	}

	void SetNumber(Sprite number){
		this.GetComponent<SpriteRenderer> ().sprite = number;
	}

	void SetRandomNumber(){
		SetNumber (GetRandomNumber ());
	}

	Sprite GetRandomNumber(){
		int numberId = Random.Range (0, 9);
		return numberSprites[numberId];
	}

}
