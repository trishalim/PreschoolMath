using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RegisterStudentListener : MonoBehaviour {

	public InputField username;
	public InputField f_name;
	public InputField l_name;
	public InputField month;
	public InputField day;
	public InputField year;
	public Dropdown sex;
	public Text errorMessage;

	void Start() {
		GetComponent<Button>().onClick.AddListener(() => ClickListener());
	}

	void ClickListener () {
		WWWForm form = new WWWForm ();
		form.AddField ("username", username.text);
		form.AddField ("f_name", f_name.text);
		form.AddField ("l_name", l_name.text);
		form.AddField ("month", month.text);
		form.AddField ("day", day.text);
		form.AddField ("year", year.text);
		form.AddField ("sex", sex.options[sex.value].text);
		form.AddField ("guardian_username", UserController.username);
		WWW w = new WWW ("http://localhost/PreschoolMath/register_student.php", form);
		StartCoroutine (Call (w));
	}

	IEnumerator Call (WWW w){
		yield return w;
		Debug.Log (w.text);
		if (w.text.Contains("Username already exists.")) {
			Debug.Log ("exists");
			errorMessage.text = "Username already exists.";
		}
	}
}
