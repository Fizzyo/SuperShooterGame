using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud2 : MonoBehaviour {
	Vector2 originalPos;
	public Rigidbody2D cl;

	// Use this for initialization
	void Start () {
		originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y);
		cl = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update (){
		cl.velocity = new Vector2 (1, cl.velocity.y);
		if(cl.transform.position.x > 12)
		{
			cl.transform.position = originalPos;
		}
	}
}
