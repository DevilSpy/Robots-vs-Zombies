/// This script moves the character controller forward 
/// and sideways based on the arrow keys.
/// It also jumps when pressing space.
/// Make sure to attach a character controller to the same game object.
/// It is recommended that you make only one call to Move or SimpleMove per frame.	
var speed : float = 2.0;
var jumpSpeed : float = 4.0;
var gravity : float = 18.0;
private var moveDirection : Vector3 = Vector3.zero;
function Update() {
	var controller : CharacterController = GetComponent(CharacterController);
	if (controller.isGrounded) {
		canDJump = 0;
		// We are grounded, so recalculate
		// move direction directly from axes
		moveDirection = Vector3(Input.GetAxis("Horizontal"), 0,0);
		moveDirection = transform.TransformDirection(moveDirection);
		moveDirection *= speed;
		
		if ((Input.GetKeyDown ("up"))||(Input.GetKeyDown ("w"))) {
			moveDirection.y = jumpSpeed+canDJump;
		}
	}
	
	// Apply gravity
	moveDirection.y -= gravity * Time.deltaTime;
	
	// Move the controller
	controller.Move(moveDirection * Time.deltaTime);
}