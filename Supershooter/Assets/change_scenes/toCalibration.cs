using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toCalibration : MonoBehaviour {

	public void GotoPage(string Scene)
	{

		SceneManager.LoadScene ("calibration");
	}
}
