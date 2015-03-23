using UnityEngine;
using System.Collections;

public class RooftopsComplete : MonoBehaviour {
	
	void OnTriggerEnter (Collider player){
		Application.LoadLevel ("level1");
	}
	
}