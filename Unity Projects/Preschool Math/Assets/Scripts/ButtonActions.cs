using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonActions : MonoBehaviour
{
	void Start(){
		
	}

	public void LoadLev1()
	{
		SceneManager.LoadScene("game2lev1");
	}

	public void LoadLev2()
	{
		SceneManager.LoadScene("game2lev2");
	}

	public void LoadLev3()
	{
		SceneManager.LoadScene("game2lev3");
	}

	public void LoadLev4()
	{
		SceneManager.LoadScene("game2lev4");
	}

	public void LoadLev5()
	{
		SceneManager.LoadScene("game2lev5");
	}
}
