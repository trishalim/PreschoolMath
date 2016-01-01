using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CreateStudentListener : MonoBehaviour {

	void Start () {
		GetComponent<Button>().onClick.AddListener(() => ClickListener());
	}

	void ClickListener() {
		Debug.Log ("enroll click");
		Application.LoadLevel (3);
	}
}
