using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
	public float speed = 500;
	
	public void FixedUpdate() {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3(moveHorizontal, 0.0F, moveVertical);
		rigidbody.AddForce(movement * speed * Time.deltaTime);
	}
}
