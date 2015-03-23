using UnityEngine;
using System.Collections;

public class MoveRobot : MonoBehaviour {
	//Variables
	public float speed = 6.0F;
	public float jumpSpeed = 8.0F; 
	public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;
	public float canDJump = 1;
	
	void Update() {
		CharacterController controller = GetComponent<CharacterController>();
		// is the controller on the ground?
		if (controller.isGrounded) {
			if (GameData.jetpackCollected){
				canDJump = 0;
			}else {canDJump = 1;}
			//Feed moveDirection with input.
			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
			moveDirection = transform.TransformDirection(moveDirection);
			//Multiply it by speed.
			moveDirection *= speed;
			
		}
		
		//Jumping
		if ((Input.GetKeyDown ("up"))||(Input.GetKeyDown ("w"))||(Input.GetKeyDown ("space"))) {
			if(canDJump < 2){
				Debug.Log(canDJump);
				moveDirection.y = jumpSpeed;
				canDJump++;
			}
		}
		
		//player direction left
		if (Input.GetKeyDown ("left")) {
			transform.FindChild ("Graphics").rotation = Quaternion.AngleAxis(180, Vector3.up);
			GameData.playerDirection = -1;
		}
		//player direction right
		if (Input.GetKeyDown ("right")) {
			transform.FindChild ("Graphics").rotation = Quaternion.AngleAxis(0, Vector3.up);
			GameData.playerDirection = 1;
		}
		
		//Applying gravity to the controller
		moveDirection.y -= gravity * Time.deltaTime;
		//Making the character move
		controller.Move(moveDirection * Time.deltaTime);
	}
}