using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		GetComponent<UnityEngine.UI.Text> ().text = "COINS: " + Convert.ToString (PlayerPrefs.GetInt ("totalcoins"));
	}
}
