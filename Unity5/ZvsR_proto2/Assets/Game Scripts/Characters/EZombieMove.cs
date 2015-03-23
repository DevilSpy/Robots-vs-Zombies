using UnityEngine;
using System.Collections;

public class EZombieMove : MonoBehaviour {
	public float speed;
	public float distance;
	private float xStartPosition;
	
	void Start () {
		xStartPosition = transform.position.x;
	}
	void Update () {
		if ((speed < 0 && transform.position.x < xStartPosition) || (speed > 0 && transform.position.x > xStartPosition + distance))
		{
			speed *= -1;
		}
		transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
	}

	void OnTriggerEnter (Collider target){
		if (target.gameObject.tag.Equals ("Player") == true) {
			Application.LoadLevel ("choose_character");
		} else if (target.gameObject.tag.Equals ("Water_ground") == true) {
		} else {
			speed *= -1;
		}
	}
}
