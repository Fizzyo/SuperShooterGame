using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dead2d : MonoBehaviour {
	GameObject main;
	
	void OnTriggerExit2D(Collider2D other ){
		if (other.name == "tornado(Clone)" || other.name == "hammer(Clone)" || other.name == "wood(Clone)") {
			main = GameObject.Find ("default_character");
			main.GetComponent<main>().ins_w=false;
			main.GetComponent<main> ().ins_t = false;
			main.GetComponent<main> ().button_pressed = false;
			main.GetComponent<main> ().breath = false;
			main.GetComponent<main> ().callturn = false;
		}
		Destroy (other.gameObject);
	}
}
