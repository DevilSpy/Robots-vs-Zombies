using UnityEngine;
using System.Collections;

public class WaterTrigger : MonoBehaviour {

	void OnTriggerEnter (Collider player){
		if (GameData.chosenCharacter == "robot") {
			Application.LoadLevel ("choose_character");
		} else {
			if(!GameData.swimsuitCollected){
				Application.LoadLevel ("choose_character");
			}
		}
	}

}
