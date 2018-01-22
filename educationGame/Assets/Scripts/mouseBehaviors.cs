using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class mouseBehaviors : MonoBehaviour
{
	public int mouseCount = 0;

	public void Play()
	{
		mouseCount += 1;
		Debug.Log (mouseCount);
	}
}
