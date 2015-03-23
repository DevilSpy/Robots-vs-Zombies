using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	public int startingHealth = 5;            // The amount of health the enemy starts the game with.
	public int currentHealth;                   // The current health the enemy has.
	
	void Awake ()
	{
		//capsuleCollider = GetComponent <CapsuleCollider> ();
		
		// Setting the current health when the enemy first spawns.
		currentHealth = startingHealth;
	}

	public void TakeDamage (int amount)
	{
		// Reduce the current health by the amount of damage sustained.
		currentHealth -= amount;
		Debug.Log (currentHealth);
		
		// If the current health is less than or equal to zero...
		if(currentHealth <= 0)
		{
			// ... the enemy is dead.
			Death ();
		}
	}

	void Death ()
	{
		Destroy (gameObject);
	}
}
