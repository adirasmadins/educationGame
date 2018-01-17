using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class TextBoxArray : MonoBehaviour {
	[SerializeField]
	private GameObject fillBox;
	[SerializeField]
	private GameObject buttonPrefab;
	[SerializeField]
	private Canvas canvas;
	[SerializeField]
	public int length=14;
	private string alphabet="abcdefghijklmnopqrstuvwxyz";
	public 	string test = "Doggy";
	void Start()
	{
		canvas.transform.position = new Vector3 (0, 0, 0);
		//Text box
		GameObject[] box = new GameObject[length];
		int xposition2 = -50;

	
		for (int i = 0; i < 3; i++) {

			box [i] = (GameObject)Instantiate (fillBox);
			box [i].transform.SetParent (canvas.transform);
			box [i].transform.position = new Vector3 (xposition2, -50, 0);




			xposition2 = xposition2 + 50;
		}

		//Button

		GameObject[] button = new GameObject[length];
		int xposition = -150;
	

		for (int i = 0; i < 7; i++) {

			button[i] = (GameObject) Instantiate(buttonPrefab);

			button[i].transform.SetParent (canvas.transform);
			button[i].transform.position = new Vector3 (xposition, -200, 0);


			button [i].GetComponentsInChildren<Text> () [0].text = alphabet [Random.Range (0, alphabet.Length)].ToString ();
		
			xposition = xposition + 50;

		}

		xposition = -150;
		for (int i = 7; i <14; i++) {

			button[i] = (GameObject) Instantiate(buttonPrefab);

			button[i].transform.SetParent (canvas.transform);
			button[i].transform.position = new Vector3 (xposition, -250, 0);
		

			button [i].GetComponentInChildren<Text>().text = alphabet [Random.Range (0, alphabet.Length)].ToString ();
			xposition = xposition + 50;

		}

		//Random  character
		int randomNumb=0;
		List<int> loopNumb = new List<int> ();
		for (int i = 0; i < test.Length; i++) {
			randomNumb = Random.Range (0, 13);
			while (!isUnique (randomNumb, loopNumb)) {
				randomNumb = Random.Range (0, 13);
			}
			button [randomNumb].GetComponentInChildren<Text> ().text = test [i].ToString ();
			Debug.Log (button [randomNumb].GetComponentInChildren<Text> ().text);
			loopNumb.Add (randomNumb);
		}
	}

	bool isUnique(int numb, List<int> lst){
		if (lst.Contains (numb))
			return false;
		else
			return true;
	}



};
