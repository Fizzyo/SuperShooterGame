using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins_movement : MonoBehaviour {
	public bool i = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < 3 && !i) {
			transform.position = new Vector2 (transform.position.x, transform.position.y + 0.01f);
		} 
		else  {
			if (!i) {
				i = !i;
			}
		}
		if (transform.position.y > 1 && i) {
			transform.position = new Vector2 (transform.position.x, transform.position.y - 0.01f);
		} 
		else {
			if (i) {
				i = !i;
			}
		}
	}
}