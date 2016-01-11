using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SignInListener : MonoBehaviour {

	public InputField username;
	public InputField password;
	public Text errorMessage;

	void Start () {
		GetComponent<Button>().onClick.AddListener(() => Click());
	}

	void Click(){
		WWWForm form = new WWWForm();
		form.AddField("user", username.text);
		form.AddField("pw", password.text);
		WWW w = new WWW("http://localhost/PreschoolMath/login.php", form);
		StartCoroutine (ClickListener(w));
	}

	IEnumerator ClickListener (WWW w){
		yield return w;
		if (w.text.Equals ("")) {
			errorMessage.text = "Please connect to the internet.";
		} else if (w.text.Equals ("Login success")) {
			UserController.username = username.text;
			Application.LoadLevel("student_list");
		} else {
			errorMessage.text = "Invalid username/password.";
		}

	}
}
