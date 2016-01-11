using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class CreateStudentListener : MonoBehaviour {

	void Start () {
		GetComponent<Button>().onClick.AddListener(() => ClickListener());
	}

	void ClickListener() {
		Debug.Log ("enroll click");
		SceneManager.LoadScene("register_student");
	}
}
