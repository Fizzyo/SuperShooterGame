using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins_movement3 : MonoBehaviour {

	public bool i = false;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (transform.position.y < 460 && !i) {
			transform.position = new Vector2 (transform.position.x, transform.position.y + 0.01f);
		} 
		else  {
			if (!i) {
				i = !i;
			}
		}
		if (transform.position.y > 458 && i) {
			transform.position = new Vector2 (transform.position.x, transform.position.y - 0.01f);
		} 
		else {
			if (i) {
				i = !i;
			}
		}
	}
}
