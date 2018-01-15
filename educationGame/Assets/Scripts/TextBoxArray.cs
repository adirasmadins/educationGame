using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class TextBoxArray : MonoBehaviour {
	[SerializeField]
	private GameObject buttonPrefab;
	[SerializeField]
	private Canvas canvas;
	[SerializeField]
	public int length=14;
	private string alphabet="abcdefghijklmnopqrstuvwxyz";
	void Start()
	{
		GameObject[] button = new GameObject[length];
		int xposition = -150;
	
		canvas.transform.position = new Vector3 (0, 0, 0);
		for (int i = 0; i < length/2; i++) {

			button[i] = (GameObject) Instantiate(buttonPrefab);

			button[i].transform.SetParent (canvas.transform);
			button[i].transform.position = new Vector3 (xposition, -200, 0);


			button [i].GetComponentsInChildren<Text> () [0].text = alphabet [Random.Range (0, alphabet.Length)].ToString ();
		
			xposition = xposition + 50;

		}

		xposition = -150;
		for (int i = length/2; i <= length; i++) {

			button[i] = (GameObject) Instantiate(buttonPrefab);

			button[i].transform.SetParent (canvas.transform);
			button[i].transform.position = new Vector3 (xposition, -250, 0);
		

			button [i].GetComponentInChildren<Text>().text = alphabet [Random.Range (0, alphabet.Length)].ToString ();
			xposition = xposition + 50;

		}
	}

	// Update is called once per frame
	/*void Update () {
		
	}*/
}
