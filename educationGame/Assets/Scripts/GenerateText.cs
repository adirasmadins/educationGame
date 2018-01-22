using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GenerateText : MonoBehaviour {

	Text txt;
	// Use this for initialization
	void Start () {
		int i = UnityEngine.Random.Range (65, 91);
		txt = gameObject.GetComponent<Text>();
		txt.text = (Convert.ToChar (i)).ToString ();
	}
	
	// Update is called once per frame
	//void Update () {
		
	//}
}
