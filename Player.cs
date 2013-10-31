using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	private int health = 100;
	private bool isDead = false;
	
	void Start() {
		transform.animation.wrapMode = WrapMode.Loop;
		transform.animation["Death"].wrapMode = WrapMode.Once;
		transform.animation["Death"].layer = 1;
		transform.animation.Stop();	
	}
	
	public int getHealth() {
		return health;	
	}
	
	public void modHealth(int amt) {
		print ("modHealth player " + amt);
		if(isDead) {
			health = 0;
			return;
		}
		health += amt;
		if(health <= 0) {
			health = 0;
			transform.animation.Play("Death");
			//print("you died");
			isDead = true;
			GetComponent<CharacterMotor>().enabled = false;
			GetComponent<Weapon>().enabled = false;
		}
	}
	
	public bool getIsDead() {
		return isDead;	
	}
}
