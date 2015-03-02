using UnityEngine;
using System.Collections;

public class LevelStart : MonoBehaviour {

	void Start()
	{
		GameData.jetpackCollected = false;
		GameData.swimsuitCollected = false;
		Debug.Log (GameData.chosenCharacter);
		if (GameData.chosenCharacter == "robot") {
			GameObject zombie = GameObject.Find ("PlayerZ");
			Destroy (zombie);
			GameObject swimsuit = GameObject.Find ("Swimsuit");
			Destroy (swimsuit);
		} else {
			GameObject robot = GameObject.Find ("PlayerR");
			Destroy (robot);
			GameObject jetpack = GameObject.Find ("Jetpack");
			Destroy (jetpack);
		}
	}
	

}
