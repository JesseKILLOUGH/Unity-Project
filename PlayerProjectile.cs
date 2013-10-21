using UnityEngine;
using System.Collections;

public class PlayerProjectile : MonoBehaviour {
	public Rigidbody projectile; // set this to your gameobject in the inspector.
	public string projectileTag = "bullet"; // change this to the tag of your gameobject. if you don't know how to create a new tag, talk to me.
	public int myHealth = 100;
	
	void Update() {
		if(Input.GetButtonDown("Fire1")) {
			Rigidbody clone = (Rigidbody) Instantiate(projectile, transform.position + new Vector3(0, 1, 0), transform.rotation); // you may wish to change "new Vector3(0, 1, 0);". 1 is the y-axis. it can be in floating point.
			//clone.velocity = transform.TransformDirection(Vector3.forward * 100);
			clone.AddForce(Camera.main.transform.forward * 5000); // we use AddForce, because velocity does not affect the y-axis.
			                                                      // it shoots from the camera. 
		}
	}

	void OnTriggerEnter(Collider other) {
		if(other.tag == projectileTag) { // the bullet hit this player.
			other.gameObject.SetActive(false);
      myHealth -= 25; //demonstrative. change it if you want.
		}
	}
}
