using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class setting: MonoBehaviour {
	string a;
	public void play()
	{
		GameObject.Find ("clickaudio").GetComponent<AudioSource>().Play();
		Debug.Log ("thisthis");
		Debug.Log (this);
	}
	void go()
	{
		SceneManager.LoadScene (a);
	}
	public void GotoPage(string star)
	{	a = star;
		Invoke ("go", 0.2f);
	}
		

}