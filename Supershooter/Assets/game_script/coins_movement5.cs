using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins_movement5 : MonoBehaviour {

	public bool i = false;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (transform.position.x < 1 && !i) {
			transform.position = new Vector2 (transform.position.x + 0.01f, transform.position.y );
		} 
		else  {
			if (!i) {
				i = !i;
			}
		}
		if (transform.position.x > -3 && i) {
			transform.position = new Vector2 (transform.position.x - 0.01f, transform.position.y);
		} 
		else {
			if (i) {
				i = !i;
			}
		}
	}
}
