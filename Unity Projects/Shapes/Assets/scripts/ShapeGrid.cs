using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ShapeGrid : MonoBehaviour {

	public GameObject[] shapes;

	void Start(){
		StartCoroutine(UpdateGrid());
	}

	IEnumerator UpdateGrid(){
		while (true) {
			SetGrid ();
			yield return new WaitForSeconds(2);
		}
	}

	void SetGrid(){
		int col = 3, row = 3;
		for (int y = 0; y < row; y++) {
			for (int x = 0; x < col; x++) {
				int shapeId = (int)Random.Range (0, 4.9999f);
				GameObject shape = Instantiate (shapes[shapeId]);
				shape.AddComponent<ShapeBehavior>();
				shape.transform.localScale = new Vector3(1.3f, 1.3f, 0);
				shape.transform.position = new Vector3((float)x*4+4, (float)y*4-4f, 0f);
			}
		}
	}

}
