using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rank_update : MonoBehaviour {
	int temp;
	string real_rank;
	// Use this for initialization
	void Start () {
		temp = Convert.ToInt32 (PlayerPrefs.GetString("rank"));

		if (temp > 28) {
			temp -= 28;
			real_rank = "GOLD ";
		} else if (temp > 14) {
			temp -= 14;
			real_rank = "SILVER ";
		} else {
			real_rank = "BRONZE ";
		}
		GameObject.Find ("Title").GetComponent<UnityEngine.UI.Text>().text = "your current rank is " + real_rank + PlayerPrefs.GetString("rank");
		GameObject.Find("1").GetComponent<SpriteRenderer>().sprite = (Sprite)Resources.Load ("rank/"+ PlayerPrefs.GetString("rank"), typeof(Sprite));
	}
	

}
