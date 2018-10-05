using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level1 : MonoBehaviour {
	
	public void GotoPage()
	{
		SceneManager.LoadScene ("Main");
	}
}
