using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {
	
	public float fireRate = 0;
	public float Damage = 10;
	public LayerMask whatToHit;
	
	LineRenderer line;
	int laserTimer = 0;
	
	float timeToFire = 0;
	Transform firePoint;
	
	// Use this for initialization
	void Awake () {
		firePoint = transform.FindChild ("FirePoint");
		line = firePoint.GetComponent<LineRenderer>();
		line.enabled = false;
		if (firePoint == null) {
			Debug.LogError("No firepoint");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		laserTimer++;
		
		if (fireRate == 0) {
			if (Input.GetKeyDown ("x")) {
				Shoot ();
			}
		} else {
			if(Input.GetKey("x") && Time.time > timeToFire){
				timeToFire = Time.time + 1/fireRate;
				Shoot();
			}
		}
		
		if (laserTimer >= 8) {
			laserTimer = 0;
			line.enabled = false;
		}
	}
	
	void Shoot(){
		Vector3 firePointPosition = new Vector3 (firePoint.position.x, firePoint.position.y, firePoint.position.z);
		Vector3 fireDirectionPosition = new Vector3 (firePoint.position.x*GameData.playerDirection*2, firePoint.position.y, firePoint.position.z);
		//RaycastHit hit = Physics.Raycast (firePointPosition, fireDirectionPosition - firePointPosition, 1, whatToHit);
		//Debug.Log ("shoooot");
		RaycastHit hit;
		if (Physics.Raycast(firePointPosition, (fireDirectionPosition - firePointPosition)*3, out hit))
		{
			Collider target = hit.collider; // What did I hit?
			float distance = hit.distance; // How far out?
			Vector3 location = hit.point; // Where did I make impact?
			GameObject targetGameObject = hit.collider.gameObject; // What's the GameObject?
			Debug.DrawRay(firePointPosition, hit.point, Color.red);
			Debug.Log ("You hit "+target);
			
			line.SetPosition(0, firePointPosition);
			line.SetPosition(1, location);
			line.enabled = true;
			
			// Try and find an EnemyHealth script on the gameobject hit.
			EnemyHealth enemyHealth = target.GetComponent <EnemyHealth> ();
			
			// If the EnemyHealth component exist...
			if(enemyHealth != null)
			{
				// ... the enemy should take damage.
				enemyHealth.TakeDamage (1);
			}
		}
	}
}
