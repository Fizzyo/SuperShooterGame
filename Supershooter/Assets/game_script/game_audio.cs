using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_audio : MonoBehaviour {
	healthbar_enemy enemy;
	static bool played = false;
	// Use this for initialization
	void Start () {


		enemy = GameObject.Find ("bat").GetComponent<healthbar_enemy> ();

		
	}
	
	// Update is called once per frame
	void Update () {
		if (enemy.isDead && !played) {
			AudioSource audio = this.GetComponent<AudioSource>();
			audio.clip = (AudioClip)Resources.Load ("sound/boom", typeof(AudioClip));
			audio.Play ();
			played = true;
			Debug.Log(audio.isPlaying);
		}
		
	}
}
