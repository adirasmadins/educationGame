using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class TextBoxArray : MonoBehaviour {

	private GameObject textBox;

	private Canvas canvas;
	public int length=5;

	void Start()
	{
		GameObject[] button = new GameObject[length];
		int position = 0;
		canvas.transform.position = new Vector3 (0, 0, 0);
		for (int i = 0; i < length; i++) {
			
			button[i] = (GameObject) Instantiate(textBox);
			button[i].transform.SetParent (canvas.transform);
			button[i].transform.position = new Vector3 (position+50, -100, 0);
		}
	

	}

	// Update is called once per frame
	/*void Update () {
		
	}*/
}
