using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abuy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetString (this.name) != "") {
			GetComponent<UnityEngine.UI.Button> ().interactable = true;
		}
	}
	

}
