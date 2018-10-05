using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour {
	public float speed;
	// Use this for initialization
	public Rigidbody2D tornado;
	void Awake () {
		
		SpriteRenderer sprite;
		sprite = GetComponent<SpriteRenderer>();
		sprite.sortingLayerName = "enemy";
		speed = 15;
		tornado = GetComponent<Rigidbody2D>();
		tornado.velocity = transform.right * -speed;

		
	}
		

	// Update is called once per frame
	void Update () {
		


	}
}
