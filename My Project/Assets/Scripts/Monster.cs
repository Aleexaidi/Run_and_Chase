using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {

	private Animator animComp;
	private CharacterController controller;
	public float speed = 20.0f;
	// Use this for initialization

	public void Start () {
		animComp = this.GetComponent<Animator>();
		controller =GetComponent<CharacterController> ();
		animComp.SetInteger ("Run_state", 1);
		controller.Move ((Vector3.forward * speed ) );
	}

	// Update is called once per frame
	public void Update () {

		if (Input.GetKeyDown (KeyCode.UpArrow)) {


			controller.Move ((Vector3.forward * speed ) );
				
		}

		}
	}

