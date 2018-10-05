using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gopage : MonoBehaviour {
	void gotopage(string star){
		SceneManager.LoadScene (star);
	}
}
