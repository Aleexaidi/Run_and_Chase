using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SpeedIncrease : MonoBehaviour {

	private CharacterController controller;
	public float speed = 5.0f;

	// Use this for initialization
	void Start () {

		controller =GetComponent<CharacterController> ();



	}

	// Update is called once per frame
	void Update () {

		controller.Move ((Vector3.forward * speed )*Time.deltaTime );

		if (Input.GetKeyDown (KeyCode.UpArrow)) {

			speed++;


			
}
}

}