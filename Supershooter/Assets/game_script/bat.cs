using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class bat : MonoBehaviour {
//	healthbar_enemy EnemyHealth;
//	bool isDead;                                                // Whether the player is dead.
//	bool damaged;   // True when the player gets damaged.
//	GameObject enemy;
//	void Start(){
//	enemy = GameObject.Find("bat");
//		EnemyHealth = enemy.GetComponent <healthbar>;
//	}
//
//	void Update()
//	{
//	void OnTriggerExit(Collider other){
//			EnemyHealth.TakeDamage(100):
//		}
//	
//	}
	GameObject enemy;
	healthbar_enemy EnemyHealth;

	void OnTriggerExit2D(Collider2D other){
		if (other.name ==  "tornado(Clone)" || other.name == "hammer(Clone)" || other.name == "wood(Clone)") {
			Debug.Log ("AAAAA");
		} else {
			enemy = GameObject.Find ("bat");
			EnemyHealth = enemy.GetComponent<healthbar_enemy> ();
			EnemyHealth.TakeDamage (60 - 2* Convert.ToInt32(PlayerPrefs.GetString("rank")) + Convert.ToInt32(PlayerPrefs.GetString("gb"))*2);
			Destroy (other.gameObject);
		}
	}
}
