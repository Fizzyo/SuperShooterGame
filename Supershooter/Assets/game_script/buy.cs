using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buy : MonoBehaviour {
	

	void Start(){
//		PlayerPrefs.DeleteAll ();
//		PlayerPrefs.SetInt ("totalcoins", 10000);  // for testing
		Debug.Log (PlayerPrefs.GetString (this.name));
		if (PlayerPrefs.GetString (this.name) != "") {
			Destroy (this.gameObject);
		}
	}
	public void buy_c()
	{
		if (PlayerPrefs.GetInt ("totalcoins") >= Convert.ToInt32(this.name)) {
			PlayerPrefs.SetInt ("totalcoins", PlayerPrefs.GetInt ("totalcoins") - Convert.ToInt32(this.name));
			PlayerPrefs.SetString (this.name, this.name);
			SceneManager.LoadScene ("champions");
		}
	


	}
}
