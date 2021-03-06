﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class StudentListController : MonoBehaviour {

	public Transform entry;
	public Transform body;
	public Transform row;

	void Start () {
		WWWForm form = new WWWForm ();
		form.AddField ("guardian_username", "Trisha");
		String url = Url.url + "/retrieve_students.php";
		WWW w = new WWW("url", form);
		//WWW w = new WWW("http://localhost/PreschoolMath/retrieve_students.php", form);
		StartCoroutine (RetrieveStudents (w));
	}

	IEnumerator RetrieveStudents(WWW w){
		yield return w;
		Debug.Log (w.text);
		FillList (w.text);
	}

	void FillList(string strList) {
		string[] studentData;
		string[] studentList = strList.Split (';');
		//int startX = -253;
		//int startY = 70;
		//int addX = 100;
		//int addY = 30;
		for (int y = 0; y<studentList.Length; y++ ) {
			string student = studentList[y];
			studentData = student.Split(',');
			for(int x = 0; x<studentData.Length; x++) {
				string data = studentData[x];
				if (x==3) {
					data = getAgeFromBirthdate(data).ToString();
				} else if (x==4) {
					data = getSex(data).ToString();
				} 
				//GameObject obj = Instantiate(entry, new Vector3(addX*x+startX, addY*y+startY, 0), Quaternion.identity) as GameObject;
			//	GameObject e = Instantiate(row, new Vector3(startX + 100*x, startY + 40*y, 0), Quaternion.identity) as GameObject;
				//e.GetComponent<Text> ().text = data;
				//e.transform.SetParent (GameObject.Find("Canvas").transform);
			}
		}
	}

	int getAgeFromBirthdate(string birthdate){
		string[] a = birthdate.Split ('-');
		DateTime now = DateTime.Today;
		if (now.Month > Int32.Parse(a [1]) && now.Day > Int32.Parse (a [2])) {
			return now.Year-Int32.Parse(a[0]);
		}
		else return now.Year-Int32.Parse(a[0])-1;
	}

	string getSex(string sex){
		return (sex.Equals ("F") ? "Female" : "Male");
	}
}
