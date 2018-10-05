using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class healthbar_enemy : MonoBehaviour
{
	public int startingHealth = 100;                            // The amount of health the player starts the game with.
	public int currentHealth;                                   // The current health the player has.
	public Slider healthSlider;                                 // Reference to the UI's health bar.
	public Image damageImage;                                   // Reference to an image to flash on the screen on being hurt.
	public AudioClip deathClip;                                 // The audio clip to play when the player dies.
	public float flashSpeed = 5f;                               // The speed the damageImage will fade at.
	public Color flashColour = new Color(1f, 0f, 0f, 0.1f);     // The colour the damageImage is set to, to flash.



	public bool isDead;                                                // Whether the player is dead.
//	bool damaged;                                               // True when the player gets damaged.

	Animator anim; 
	GameObject bat;

	void Awake ()
	{
		


		bat =  GameObject.Find("bat");
		anim = bat.GetComponent<Animator> ();
		currentHealth = startingHealth;
	}


	void Update ()
	{



	}


	public void TakeDamage (int amount)
	{
		// Set the damaged flag so the screen will flash.
//		damaged = true;

		// Reduce the current health by the damage amount.
		currentHealth -= amount;

		// Set the health bar's value to the current health.
		healthSlider.value = currentHealth;


		if(currentHealth <= 0 && !isDead)
		{
			// ... it should die.
			Death ();
		}
	}

	void load()
	{
		SceneManager.LoadScene ("victory");

	}
	void Death ()
	{
		// Set the death flag so this function won't be called again.
		isDead = true;
		anim.Play ("explosion");
		Invoke ("load", 1.8f);

	}       
}