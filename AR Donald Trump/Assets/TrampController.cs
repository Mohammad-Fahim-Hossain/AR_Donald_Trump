﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class TrampController : MonoBehaviour {
	private Rigidbody rb;
	private Animation Anim;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		Anim = GetComponent<Animation> ();
	}
	
	// Update is called once per frame
	void Update () {
		

		float x = CrossPlatformInputManager.GetAxis ("Horizontal");
		float y = CrossPlatformInputManager.GetAxis ("Vertical");

		Vector3 Movement = new Vector3 (x, 0, y);
		rb.velocity = Movement * 2f;

		if (x != 0 && y != 0) {
			transform.eulerAngles=new Vector3(transform.eulerAngles.x,Mathf.Atan2(x,y)*Mathf.Rad2Deg,transform.eulerAngles.z);

		}
		if(x!=0 || y!=0){
			Anim.Play("walk");
		}
		else{
			Anim.Play("idle");
		}
	}
}
