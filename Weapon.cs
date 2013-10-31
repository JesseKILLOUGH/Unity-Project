using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {
	public Transform sword;
	public Transform shield;

	void Start() {
		sword.animation.wrapMode = WrapMode.Loop;
		sword.animation["SwordSwing2"].wrapMode = WrapMode.Once;
		sword.animation["SwordSwing2"].layer = 1;
		sword.animation.Stop();
		
		shield.animation.wrapMode = WrapMode.Loop;
		shield.animation["Block1"].wrapMode = WrapMode.Once;
		shield.animation["Block1"].layer = 1;
		shield.animation.Stop();
	}
	
	// Update is called once per frame
	void Update() {
		if(Input.GetButtonDown("Fire1")) {
			//sword.transform.localPosition = Vector3.Slerp(sword.localPosition, new Vector3(1, 0, 1), 0.1f);
			sword.animation.Play("SwordSwing2");
		}
		
		if(Input.GetButtonDown("Fire2")) {
			shield.animation["Block1"].speed = 1;
			shield.animation.Play("Block1");
		} else if(Input.GetButtonUp("Fire2")) {
			shield.animation["Block1"].speed = -1;
			shield.animation.Play("Block1");
		}
	}
}
