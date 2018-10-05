using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initialise : MonoBehaviour {

	// Use this for initialization
	void Start () {

		if (PlayerPrefs.GetString ("rank") == "") {
			PlayerPrefs.SetString ("rank", "1");
		}

		if (PlayerPrefs.GetString ("gb") == "") {
			PlayerPrefs.SetString ("gb", "0");
		}
		if (PlayerPrefs.GetString ("bb") == "") {
			PlayerPrefs.SetString ("bb", "0");
		}
		
	}
	void Update(){
		if (Input.GetButtonDown ("Fire1")) {
			Debug.Log ("down");
		}
		if (Input.GetButtonUp ("Fire1")) {
			Debug.Log ("up");
		}
	}

}
