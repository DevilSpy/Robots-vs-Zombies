using UnityEngine;
using System.Collections;

public class ToMainMenu : MonoBehaviour {

	private void OnGUI(){
		if (GUI.Button (new Rect (0, 0, 100, 70), "Main Menu")) {
			Application.LoadLevel ("main_menu");
		}

	}
}