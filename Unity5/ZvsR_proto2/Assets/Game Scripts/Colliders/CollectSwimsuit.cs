using UnityEngine;
using System.Collections;

public class CollectSwimsuit : MonoBehaviour {

	void OnTriggerEnter (Collider player){
		GameObject swimsuit = GameObject.Find ("Swimsuit");
		Destroy (swimsuit);
		GameData.swimsuitCollected = true;
	}
}
