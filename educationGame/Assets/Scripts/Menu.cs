using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public void Play (int i)
	{
		switch (i) {
		case 1:
			{
				SceneManager.LoadScene ("Game");
				break;
			}
		case 2:
			{
				SceneManager.LoadScene ("Game2");
				break;

			}
		case 3:
			{
				Application.Quit ();
				break;
			}
		default:
			{
				break;
			}
		}
		
	}
}
