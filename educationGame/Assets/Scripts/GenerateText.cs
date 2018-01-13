using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateText : MonoBehaviour {

	Text txt;
	// Use this for initialization
	void Start () {
		int i = Random.Range (1, 100);
		txt = gameObject.GetComponent<Text>();
		txt.text = i.ToString();
	}
	
	// Update is called once per frame
	//void Update () {
		
	//}
}
