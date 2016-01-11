using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EnrollListener : MonoBehaviour {

	public InputField username;
	public Text errorMessage;

	void Start (){
		GetComponent<Button> ().onClick.AddListener (() => ClickListener ());
	}

	void ClickListener (){
		if (username.text.Equals ("")) {
			Debug.Log ("Please input username.");
		} else {
			WWWForm form = new WWWForm ();
			form.AddField ("student_username", username.text);
			form.AddField ("guardian_username", UserController.username);
			WWW w = new WWW("http://preschoolmath.x10host.com/enroll_student.php", form);
			StartCoroutine(Call (w));
		}
	}

	IEnumerator Call (WWW w){
		yield return w;
		Debug.Log (w.text);
		if (!w.text.Equals ("")) {
			errorMessage.text = w.text;
		}
	}

}
