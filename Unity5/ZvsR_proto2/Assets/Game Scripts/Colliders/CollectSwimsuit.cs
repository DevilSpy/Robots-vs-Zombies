using UnityEngine;
using System.Collections;

public class CollectSwimsuit : MonoBehaviour {

	void OnTriggerEnter (Collider target){
		if (target.gameObject.tag.Equals ("Player") == true) {
			GameObject swimsuit = GameObject.Find ("Swimsuit");
			Destroy (swimsuit);
			GameData.swimsuitCollected = true;
		}
	}
}
