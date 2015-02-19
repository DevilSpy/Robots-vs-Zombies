using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	private void OnGUI(){
		if (GUI.Button (new Rect (0, 0, 100, 70), "New Game")) {
			Application.LoadLevel ("choose_character");
		}
		if (GUI.Button (new Rect (120, 0, 100, 70), "Score Board")) {
			Application.LoadLevel ("score_board");
		}
		if (GUI.Button (new Rect (240, 0, 100, 70), "Instructions")) {
			Application.LoadLevel ("instructions");
		}
	}
}
