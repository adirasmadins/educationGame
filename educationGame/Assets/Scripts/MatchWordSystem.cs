using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class MatchWordSystem : MonoBehaviour {
	[SerializeField]
	private GameObject buttonPrefab;
	[SerializeField]
	private Canvas canvas;
	public int length=7;
	[SerializeField]
	private float xMouse;
	[SerializeField]
	private float yMouse;
	[SerializeField]
	private string delogX;
	[SerializeField]
	private string delogY;
	private float currentX;
	private float currentY;
	[SerializeField]
	private bool Hit;
	private RaycastHit hit;
	public Camera camera;
	private Ray ray;

	void Start()
	{
		GameObject[] button = new GameObject[length];
		int xposition = -150;
		int yposition = -150;
		canvas.transform.position = new Vector3 (0, 0, 0);
		for (int i = 0; i < length; i++) 
		{
			xposition = -150;
			for (int j = 0; j < length; j++)
			{
				button[i] = (GameObject) Instantiate(buttonPrefab);
				button[i].transform.SetParent (canvas.transform);
				button[i].transform.position = new Vector3 (xposition, yposition, 0);
				xposition += 50;
			}
			yposition += 50;
		}
		currentX = currentY = 0;
		ray = camera.ScreenPointToRay (Input.mousePosition);
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
	void Update () 
	{
		xMouse = Input.GetAxis("Mouse X");
		currentX += xMouse;
		yMouse = Input.GetAxis("Mouse Y");
		currentY += yMouse;
		if (xMouse < 0)
			delogX = "Left";
		else if (xMouse > 0)
			delogX = "Right";
		if (yMouse < 0)
			delogY = "Down";
		else if (yMouse > 0)
			delogY = "Up";
		
	}
}
