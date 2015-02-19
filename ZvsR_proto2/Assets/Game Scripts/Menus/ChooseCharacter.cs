using UnityEngine;
using System.Collections;

public class ChooseCharacter : MonoBehaviour {

	private void OnGUI(){
		if (GUI.Button (new Rect (Screen.width/2-110, Screen.height/2-35, 100, 70), "Robot")) {
			Application.LoadLevel ("level1_robot");
		}
		if (GUI.Button (new Rect (Screen.width/2+10, Screen.height/2-35, 100, 70), "Zombie")) {
			Application.LoadLevel ("level1_zombie");
		}
	}
}
