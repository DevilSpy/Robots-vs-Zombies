using UnityEngine;
using System.Collections;

public class FallOffTrigger : MonoBehaviour {
	
	void OnTriggerEnter (Collider player){
		Application.LoadLevel ("choose_character");
	}
	
}