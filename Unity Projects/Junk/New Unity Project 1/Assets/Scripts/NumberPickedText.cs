using UnityEngine;
using System.Collections;

public class NumberPickedText : MonoBehaviour {

	public static int number;
	public static GUIText text;
	public static string displayTxt;
	// Use this for initialization
	void Start () {
		text = GetComponent<GUIText> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = displayTxt;
	}

	public static void DisplayNum (int num){
		number = num + 1;
		displayTxt = "" + number;
	}

	public static void Message (string msg){
		displayTxt = msg;
	}
}
