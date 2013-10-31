using UnityEngine;
using System.Collections;

public class Aggressive : MonoBehaviour {
	private RaycastHit hit;
	public Transform target;
	public float strength = 0.5F;
	public float speed = 10;
	public float maxDistance = 5.5F;
	public float hitDistance = 1.5F;
	private CharacterController controller;
	public Transform weapon;
	
	void Awake() {
		controller = GetComponent<CharacterController>();	
	}
	
	// Update is called once per frame
	void Update () {
		float distance = Vector3.Distance(transform.position, target.transform.position);
		var fwd = transform.TransformDirection (Vector3.forward);
		//print ("NPC distance from target: " + distance);
		if(!target.GetComponent<Player>().getIsDead() && !GetComponent<NPC>().getIsDead()) {
			if(distance <= hitDistance) {
				if(Random.Range(0, 2) > 1) {
					weapon.animation.Play("SwordSwing2");
				}
			} else if(distance <= maxDistance) {
				Quaternion rotate = Quaternion.LookRotation(target.position - transform.position);
				float str = Mathf.Min(strength * Time.deltaTime, 1);
				transform.rotation = Quaternion.Lerp(transform.rotation, rotate, str);
				controller.SimpleMove(fwd * speed);
			} else {
				Quaternion rotate = Quaternion.LookRotation(transform.position);
				transform.rotation = Quaternion.Lerp (transform.rotation, rotate, Mathf.Min (strength * Time.deltaTime, 1));
			}
		}
	}
}
