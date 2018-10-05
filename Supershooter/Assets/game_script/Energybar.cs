using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Energybar : MonoBehaviour
{
	
	public Slider EnergySlider;                                 // Reference to the UI's health bar.                                   // Reference to an image to flash on the screen on being hurt.
	public AudioClip deathClip;                                 // The audio clip to play when the player dies.
	public float flashSpeed = 5f;                               // The speed the damageImage will fade at.
	public Color flashColour = new Color(1f, 0f, 0f, 0.1f);     // The colour the damageImage is set to, to flash.


	bool isDead;                                                // Whether the player is dead.
	bool damaged;                                               // True when the player gets damaged.


	public void set ()
	{
		EnergySlider.value = 0;

	}

//	void Update()
//	{
//		Invoke ("charge", 0.1f);
//	}
//


	public void charge(float a)
	{

		EnergySlider.value += a;

	}
}
