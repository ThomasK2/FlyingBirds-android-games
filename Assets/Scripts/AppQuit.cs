using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppQuit : MonoBehaviour {
	
	// Update is called once per frame
	void Quit () 
	{
		if (Application.platform == RuntimePlatform.Android) 
		{
			Application.Quit ();
			return;
		}
	}
}
