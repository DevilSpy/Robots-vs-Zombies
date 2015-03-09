using UnityEngine;
using System.Collections;

public class CollectJetpack : MonoBehaviour {

	void OnTriggerEnter (Collider player){
		GameObject jetpack = GameObject.Find ("Jetpack");
		Destroy (jetpack);
		GameData.jetpackCollected = true;
	}
}
