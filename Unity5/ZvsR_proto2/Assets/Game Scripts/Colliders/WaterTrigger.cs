using UnityEngine;
using System.Collections;

public class WaterTrigger : MonoBehaviour {

	void OnTriggerEnter (Collider target){
		if (target.gameObject.tag.Equals ("Player") == true) {
			if (GameData.chosenCharacter == "robot") {
				Application.LoadLevel ("choose_character");
				GameData.jetpackCollected = false;
			} else {
				if (!GameData.swimsuitCollected) {
					Application.LoadLevel ("choose_character");
					GameData.swimsuitCollected = false;
				}
			}
		}
	}

}
