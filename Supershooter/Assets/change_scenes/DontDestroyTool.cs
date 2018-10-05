using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyTool : MonoBehaviour {  
	static bool created = false;  

	void Awake()  
	{  

		if (!created) {
			DontDestroyOnLoad (this);
			GetComponent<AudioSource> ().Play ();
			created = true;
		}
		
	}  
}