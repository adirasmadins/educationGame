using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class MatchWordSystem : MonoBehaviour {
	[SerializeField]
	private GameObject buttonPrefab;
	[SerializeField]
	private Canvas canvas;
	public int length=5;

	void Start()
	{
		GameObject[] button = new GameObject[length];
		int xposition = 0;
		canvas.transform.position = new Vector3 (0, 0, 0);
		for (int i = 0; i < length; i++) {

			button[i] = (GameObject) Instantiate(buttonPrefab);
			button[i].transform.SetParent (canvas.transform);
			button[i].transform.position = new Vector3 (xposition, -100, 0);
			xposition = xposition + 50;
		}
		/*
		canvas.transform.position = new Vector3 (0, 0, 0);
		GameObject button = (GameObject) Instantiate(buttonPrefab);
		button.transform.SetParent (canvas.transform);
		button.transform.position = new Vector3 (100, -100, 0);
		GameObject button1 = (GameObject) Instantiate(buttonPrefab);
		button1.transform.SetParent (canvas.transform);
		button1.transform.position = new Vector3 (150, -100, 0);*/
	}
	
	// Update is called once per frame
	/*void Update () {
		
	}*/
}
