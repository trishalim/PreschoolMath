using UnityEngine;
using System.Collections;

public class Problem : MonoBehaviour {

	public GameObject[] first;
	public GameObject[] second;
	GameObject operation;
	int firstNum, secondNum;
	char operationChar;
	int answer;

	void Start(){
		operationChar = '+';
		firstNum = (int)Random.Range (1, 5);
		secondNum = (int)Random.Range (1, 5);

		//correct answer
		switch (operationChar) {
		case '+': answer = firstNum + secondNum; break;
		case '-': answer = firstNum - secondNum; break;
		}

		//create objects for first num
		first = new GameObject[firstNum];
		for (int i=0; i<firstNum; i++) {

		}

		//create object for operation
		operation = new GameObject ();

		//create objects for second num
		first = new GameObject[secondNum];
		for (int i=0; i<secondNum; i++) {
			
		}
	}

}
