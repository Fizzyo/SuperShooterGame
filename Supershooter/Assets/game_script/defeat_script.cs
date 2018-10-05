using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defeat_script : MonoBehaviour {
	string pre_rank;
	string cur_rank;
	string real_rank;
	bool created = false;
	int temp;
	GameObject rank1;
	GameObject rank2;
	GameObject arrow;
	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetString ("rank") == "") {
			PlayerPrefs.SetString ("rank", "1");
		}
		pre_rank = PlayerPrefs.GetString ("rank");
		cur_rank = Convert.ToString(Convert.ToInt32(pre_rank)- 1);
		rank1 = GameObject.Find ("01");
		rank2 = GameObject.Find ("02");
		arrow = GameObject.Find ("a");
		temp = Convert.ToInt32 (cur_rank);

		if (temp > 28) {
			temp -= 28;
			real_rank = "GOLD ";
		} else if (temp > 14) {
			temp -= 14;
			real_rank = "SILVER ";
		} else {
			real_rank = "BRAONZE ";
		}
		real_rank = "DEGRADED TO " + real_rank + Convert.ToString (temp);
		Debug.Log (PlayerPrefs.GetInt ("totalcoins"));
		PlayerPrefs.SetInt ("totalcoins", Convert.ToInt32 (PlayerPrefs.GetString ("coins")) + PlayerPrefs.GetInt ("totalcoins"));

	}
	void promote()
	{

		GameObject.Find ("promotion").GetComponent<UnityEngine.UI.Text>().text =  real_rank;
	}
	void d_promote()
	{
		GameObject.Find ("promotion").GetComponent<UnityEngine.UI.Text>().text =  "";
	}
	void rank()
	{
		rank1.GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load ("rank/"+ pre_rank, typeof(Sprite));
		rank2.GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load ("rank/"+ cur_rank, typeof(Sprite));
		arrow.GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load ("arrows", typeof(Sprite));

		PlayerPrefs.SetString ("rank", cur_rank);
	}
	void d_rank()
	{
		Destroy (rank1);
		Destroy (rank2);
		Destroy (arrow);

	}
	void stat()
	{
		GameObject.Find ("gb").GetComponent<UnityEngine.UI.Text>().text =  PlayerPrefs.GetString("gb")  + " GOOD BREATHS";
		GameObject.Find ("bb").GetComponent<UnityEngine.UI.Text>().text =  PlayerPrefs.GetString("bb")  + " BAD BREATHS";
		GameObject.Find ("c").GetComponent<UnityEngine.UI.Text>().text =  PlayerPrefs.GetString("coins")  + " COINS";
	}
	// Update is called once per frame
	void Update () {
		if (!created) {
			Invoke ("promote", 0.2f);
			Invoke ("d_promote", 2f);
			Invoke ("rank", 0.2f);
			Invoke ("d_rank", 2f);	
			Invoke ("stat", 2f);
			created = true;
		}
	}

}
