using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour {
	void OnTriggerExit2D(Collider2D other ){
		Debug.Log (other.name);
		if (other.name == "hammer(Clone)" || other.name == "wood(Clone)"|| other.name == "tornado(Clone)") {
		} 
		else {
			Debug.Log("nitmakmaf");
			Debug.Log (PlayerPrefs.GetString ("coins"));
			GameObject.Find ("default_character").GetComponent<main> ().coins += 1;
			PlayerPrefs.SetString ("coins", Convert.ToString (GameObject.Find ("default_character").GetComponent<main> ().coins));
			Destroy (this.gameObject);
		}
	}
}
