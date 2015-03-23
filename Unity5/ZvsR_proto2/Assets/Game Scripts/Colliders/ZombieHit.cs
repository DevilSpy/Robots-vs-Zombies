using UnityEngine;
using System.Collections;

public class ZombieHit : MonoBehaviour {

	void OnTriggerEnter (Collider target){
		if (target.gameObject.tag.Equals ("Player") == true) {
			Application.LoadLevel ("choose_character");
		}
	}
}