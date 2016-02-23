using UnityEngine;
using System.Collections;

public class Lives : MonoBehaviour {

	public GameObject life;
	public GameObject[] lives;
	public int count;

	void Start(){
		count = 5;
		lives = new GameObject [count];
		for (int i=0; i<count; i++){
			lives[i]=Instantiate(life);
			lives[i].transform.localScale = new Vector3(.5f,.5f,0);
			lives[i].transform.position = new Vector3(i*-1.5f,0,0);
		}
	}

	public void decrementLives(){
		Debug.Log ("lives");
		count--;
		Destroy(lives[0]);
	}

}
