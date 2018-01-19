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

	int length=14;
	private string alphabet="abcdefghijklmnopqrstuvwxyz";
	string test = "CAT";
	GameObject[] box = new GameObject[3];
	GameObject[] button = new GameObject[14];
	void Start()
	{
		
		canvas.transform.position = new Vector3 (0, 0, 0);
		//Create text box
		int xposition2 = -50;
		creatFillBox (box, xposition2);

		//Create Button
		int xposition = -150;
		creatButton (button, xposition);

		//Random  character
		randomChar (button, test);
		foreach (GameObject btn in button) {
			
			btn.GetComponent<Button> ().onClick.AddListener (() => task (btn, box));
		}


	


	}

	//Remove character when the input field is focused
	void Update(){
		foreach (GameObject inputfield in box) {

			if(inputfield.GetComponent<InputField> ().isFocused == true){
				for(int i=0; i<14;i++){
					//find null button to add the Char which is removed
					if(button[i].GetComponentsInChildren<Text>()[0].text.Length==0){
						button [i].GetComponentsInChildren<Text> () [0].text = inputfield.GetComponentsInChildren<Text> () [0].text;

						break;

					}
				}
				//Remove the Character in input Field
				inputfield.GetComponentsInChildren<Text> () [0].text = "";
			}
		}

	}

	//event for one button
	void task(GameObject button, GameObject[]	 box){
		for (int i = 0; i < box.Length; i++) {
			//Find null slot to fill the char
			if (box [i].GetComponentsInChildren<Text> () [0].text.Length==0) {
				//The char is set to the empty slot
				box[i].GetComponentsInChildren<Text> () [0].text = button.GetComponentsInChildren<Text> () [0].text;
				//Remove the char from the button
				button.GetComponentsInChildren<Text>()[0].text=null;
				//The button is disable when it's null
				if(button.GetComponentsInChildren<Text> () [0].text==null){
				button.GetComponent<Button> ().interactable = false;
				}

			}

		}

	}

	bool isUnique(int numb, List<int> lst){
		if (lst.Contains (numb))
			return false;
		else
			return true;
	}

	void creatFillBox(GameObject[] box, int xposition){
		for (int i = 0; i < 3; i++) {

			box [i] = (GameObject)Instantiate (fillBox);
			box [i].transform.SetParent (canvas.transform);
			box [i].transform.position = new Vector3 (xposition, -50, 0);
			box [i].name = "box"+i.ToString();
			xposition = xposition + 50;
		}
	}

	void creatButton(GameObject[] button,int xposition){
		for (int i = 0; i < 7; i++) {

			button[i] = (GameObject) Instantiate(buttonPrefab);

			button[i].transform.SetParent (canvas.transform);
			button[i].transform.position = new Vector3 (xposition, -200, 0);


			button [i].GetComponentsInChildren<Text> () [0].text = alphabet [Random.Range (0, alphabet.Length)].ToString ();
			button [i].name = "button" + i.ToString ();
			xposition = xposition + 50;

		}

		xposition = -150;
		for (int i = 7; i <14; i++) {

			button[i] = (GameObject) Instantiate(buttonPrefab);

			button[i].transform.SetParent (canvas.transform);
			button[i].transform.position = new Vector3 (xposition, -250, 0);


			button [i].GetComponentInChildren<Text>().text = alphabet [Random.Range (0, alphabet.Length)].ToString ();
			button [i].name = "button" + i.ToString ();
			xposition = xposition + 50;

		}
	}

	void randomChar(GameObject[] button,string test){
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
};
