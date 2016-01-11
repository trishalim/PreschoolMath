using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SignUpListener : MonoBehaviour {

	public InputField username;
	public InputField f_name;
	public InputField l_name;
	public InputField password;
	public InputField confirm_password;

	void Start () {
		GetComponent<Button>().onClick.AddListener(() => ClickListener());
	}

	void ClickListener() {
		if (password.text.Equals(confirm_password.text)) {
			WWWForm form = new WWWForm ();
			form.AddField ("username", username.text);
			form.AddField ("f_name", f_name.text);
			form.AddField ("l_name", l_name.text);
			form.AddField ("password", password.text);
			WWW w = new WWW ("http://preschoolmath.x10host.com/signup.php", form);
			StartCoroutine (Call (w));
		} else {
			Debug.Log ("Passwords don't match.");
		}
	}

	IEnumerator Call (WWW w){
		yield return w;
		Debug.Log (w.text);
	}
}
