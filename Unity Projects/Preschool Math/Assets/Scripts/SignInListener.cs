using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
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
		WWW w = new WWW("http://preschoolmath.x10host.com/unity/login.php", form);
		StartCoroutine (ClickListener(w));
	}

	IEnumerator ClickListener (WWW w){
		yield return w;
		Debug.Log (w.text);
		if (w.text.Equals ("")) {
			errorMessage.text = "Please connect to the internet.";
		} else if (w.text.Equals ("Login success")) {
			Debug.Log ("success!!!");
			UserController.username = username.text;
			SceneManager.LoadScene("mainmenu");
		} else {
			errorMessage.text = "Invalid username/password.";
		}

	}
}
