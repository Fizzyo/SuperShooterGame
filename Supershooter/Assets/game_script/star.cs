using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star : MonoBehaviour {

	void OnTriggerExit2D(Collider2D other ){
		Debug.Log (other.name);
		if (other.name == "hammer(Clone)" || other.name == "wood(Clone)" || other.name == "tornado(Clone)") {
		} 
		else {
			GameObject.Find ("playerhealthSlider").GetComponent<UnityEngine.UI.Slider>().value += 10;
			Destroy (Instantiate((GameObject)Resources.Load("healthregen", typeof(GameObject))),1f);
			Destroy (this.gameObject);
		}
	}
}
