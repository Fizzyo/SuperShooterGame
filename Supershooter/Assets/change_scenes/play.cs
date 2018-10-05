using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play: MonoBehaviour {


	public void GotoPage()
	{
		GameObject.Find ("clickaudio").GetComponent<AudioSource>().Play();
		Destroy (GameObject.Find("menuaudio"));
		SceneManager.LoadScene ("Main" + Random.Range(1,4));

	}
}
