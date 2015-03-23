using UnityEngine;
using System.Collections;

public class CollectJetpack : MonoBehaviour {

	void OnTriggerEnter (Collider target){
		if (target.gameObject.tag.Equals ("Player") == true) {
			GameObject jetpack = GameObject.Find ("Jetpack");
			Destroy (jetpack);
			GameData.jetpackCollected = true;
		}
	}
}
