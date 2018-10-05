using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fizzyo;

public class main : MonoBehaviour {
	public bool i = false;
	public bool d = false;
	public bool k = false;
	public int gb = 0;
	public int bb = 0;
	public GameObject coin;
	public int coins = 0;
	SpriteRenderer champions;
	public GameObject tor; // tornado
	public GameObject bat; // enemy
	public GameObject turn;
	public Transform character; // character position
	public GameObject weapon; // flower
	public GameObject set_speed; // weapon speed line 38
	public bool button_pressed = false;
	public bool breath = false;
	public bool last = false;
	public bool callturn = false; // call the gameobject turn
	public bool charging  = false;
	public bool ins_w = false;
	public bool ins_t = false;
	public bool isend = false;
	public float downTime, upTime, pressTime = 0;
	public float initial_velocity; // weapon velocity
	public float initial_angle;    // weapon angle
	public bool end = false;
	public float r = 0;
	public bool isrotate = true;
	void OnTriggerExit2D(Collider2D other){
		if (other.name != "weapon(Clone)") {
			Destroy (other.gameObject);
			damage ();
		}

	}


	GameObject player;                          // Reference to the player GameObject.
	healthbar playerHealth;                  // Reference to the player's health.
	Energybar energy;
	healthbar_enemy enemy;
	GameObject arrow;

	void damage()
	{
		playerHealth.TakeDamage ( 10 + Convert.ToInt32(Mathf.Floor(Convert.ToInt32(PlayerPrefs.GetString("rank"))/2)) );
		ins_w = false;
		ins_t = false;
		button_pressed = false;
		breath = false;
		callturn = false;

	}
	void ins_tor()  //  random instantiate enemy weapons
	{	
		int c = UnityEngine.Random.Range (0, 3);
		if (c == 1) {
			Instantiate (tor, new Vector2 (bat.transform.position.x -3, bat.transform.position.y+2), Quaternion.identity);
		} 
		else if (c == 0) {
			set_speed = Instantiate ((GameObject)Resources.Load ("hammer", typeof(GameObject)), new Vector2 (bat.transform.position.x - 3, bat.transform.position.y), Quaternion.identity);
			Rigidbody2D hammer;
			float angle = UnityEngine.Random.Range (0.7f, 1f);
			float v = UnityEngine.Random.Range (29f, 36f);
			hammer = set_speed.GetComponent<Rigidbody2D> ();
			hammer.velocity = new Vector2 (-v * Mathf.Cos (angle), v * Mathf.Sin (angle));
			this.GetComponent<AudioSource> ().Play ();
		} 
		else {
			set_speed = Instantiate ((GameObject)Resources.Load ("wood", typeof(GameObject)), new Vector2 (bat.transform.position.x - 3, bat.transform.position.y), Quaternion.identity);
			Rigidbody2D hammer;
			float angle = UnityEngine.Random.Range (0.6f, 0.8f);
			float v = UnityEngine.Random.Range (29f, 34f);
			hammer = set_speed.GetComponent<Rigidbody2D> ();
			hammer.velocity = new Vector2 (-v * Mathf.Cos (angle), v * Mathf.Sin (angle));
			this.GetComponent<AudioSource> ().Play ();
		}


	}
	void ins_weapon() // player weapons
	{
		set_speed = Instantiate (weapon, new Vector2(transform.position.x+1,transform.position.y),Quaternion.identity);
		Rigidbody2D flower;
		flower = set_speed.GetComponent<Rigidbody2D>();
		flower.velocity = new Vector2(initial_velocity*Mathf.Cos(initial_angle), initial_velocity*Mathf.Sin(initial_angle));
		this.GetComponent<AudioSource> ().Play();

	}

	void energybar() // charge for the energy bar
	{
		energy.charge (20);
	}

	// Use this for initialization
	void Start () {
		string champion;
		bat =  GameObject.Find("bat");
		tor  = (GameObject)Resources.Load("tornado", typeof(GameObject));
		weapon = (GameObject)Resources.Load("weapon", typeof(GameObject));
		turn = (GameObject)Resources.Load("turn", typeof(GameObject));
		player = GameObject.Find("default_character");
		//      health bar 
		playerHealth = player.GetComponent <healthbar> ();
		//      energy bar
		energy = player.GetComponent<Energybar> ();
		//      select  champion part
		champions = GameObject.Find ("default_character").GetComponent<SpriteRenderer>();
		champion = PlayerPrefs.GetString("character");
		enemy = bat.GetComponent<healthbar_enemy>();
		arrow = GameObject.Find ("arrow");
		arrow.transform.rotation= Quaternion.Euler(0f,0f,0.15f);
		Debug.Log (champion);
		if (champion != "") {
			champions.sprite = (Sprite)Resources.Load (champion, typeof(Sprite));
		} 
		bat.GetComponent<Animator>().runtimeAnimatorController = (RuntimeAnimatorController)Resources.Load("Monster/" + Convert.ToString(UnityEngine.Random.Range(1,6)), typeof(RuntimeAnimatorController));
	}

	// Update is called once per frame
	void Update () {
		if (callturn == false && playerHealth.isDead == false  && enemy.isDead == false) {
			GameObject turn1;
			turn1 = Instantiate (turn);
			Destroy (turn1, 1.5f);
			Destroy (coin);
			string c;
			c = "coins" + Convert.ToString(UnityEngine.Random.Range(1,5));
			coin = Instantiate((GameObject)Resources.Load(c, typeof(GameObject)));
			callturn = true;
			isrotate = true;
		}

		if (button_pressed == false && isrotate) {
			Debug.Log (arrow.transform.eulerAngles.z);
			if (arrow.transform.rotation.z < 0.35 && !i) {
				Debug.Log ("aaa");
				arrow.transform.Rotate (Vector3.forward * 0.9f);
			} 
			else  {
				if (!i) {
					i = !i;
				}
			}
			if (arrow.transform.rotation.z >= 0.15 && i) {
				Debug.Log ("bbb");
				arrow.transform.Rotate (Vector3.forward * -0.9f);
			} 
			else {
				if (i) {
					i = !i;
				}
			}
		}
			

		if  (button_pressed == false && (Input.GetKeyDown (KeyCode.B) || Input.GetButtonDown("Fire1") )) {
			Debug.Log ("rotatefalse");
			isrotate = false;
			initial_angle = arrow.transform.rotation.eulerAngles.z * 314 / 18000;
			Debug.Log (initial_angle);
			i = true;
			d = false;
			button_pressed = true;
		}
		Debug.Log (FizzyoFramework.Instance.Recogniser.IsExhaling);
		Debug.Log (!FizzyoFramework.Instance.Recogniser.IsExhaling && !i && k);
		if (FizzyoFramework.Instance.Recogniser.IsExhaling) {
			k = true;
		}
		if  (button_pressed == true && breath == false && (Input.GetKeyDown (KeyCode.Space)|| (FizzyoFramework.Instance.Recogniser.IsExhaling && i))) {
			Debug.Log ("keypress");
			downTime = Time.time;
			charging = true;
			energy.set ();
			i = false;

		}

		if (charging == true) {
			Invoke ("energybar", .2f);
		}
			
		if  (button_pressed == true && breath == false && (Input.GetKeyUp (KeyCode.Space)|| (!FizzyoFramework.Instance.Recogniser.IsExhaling && !i && k))) {
			Debug.Log ("keyup");
			upTime = Time.time;
			pressTime = upTime - downTime;
			initial_velocity = pressTime * 21; 
			breath = true;
			Debug.Log (initial_velocity);
			//			energy.charge (pressTime * 1000);

			charging = false;
			i = true;
			k = false;


		}

		if  (button_pressed == true && breath == true && ins_w == false) {
			if (FizzyoFramework.Instance.Recogniser.GetBreathQuality(FizzyoFramework.Instance.Recogniser.BreathPercentage)>= 1) {
				gb += 1;
				PlayerPrefs.SetString ("gb", Convert.ToString (gb));
			} 
			else {
				bb += 1;
				PlayerPrefs.SetString ("bb", Convert.ToString (bb));
			}
			ins_weapon ();

			ins_w = true;

		}
		if (button_pressed == true && breath == true && ins_w == true && ins_t == false && playerHealth.isDead == false  && enemy.isDead == false && set_speed == null) {

			Invoke("ins_tor",1);

			ins_t = true;

		}





	}
}

