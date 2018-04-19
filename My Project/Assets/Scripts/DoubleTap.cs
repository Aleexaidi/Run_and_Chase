using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DoubleTap : MonoBehaviour {

	public Button buttton;
	private CharacterController controller;
	private int counter;
	public float speed= 15.0f; 
	public float clickTimer = .5f;
	void Start () {


		controller =GetComponent<CharacterController> ();
	}

	void Update () {

		controller.Move ((Vector3.forward * speed )*Time.deltaTime );
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			buttonListner();
		}
		else if (Input.GetKeyUp (KeyCode.Mouse0)) {

			clickListner ();
		}
	}

	public void buttonListner()
	{


			StartCoroutine ("doubleCLickEvent");

		

	}
	IEnumerator doubleCLickEvent()
		{



		speed=speed+2;
	
			

			yield return new WaitForSeconds (0.0f);
				
	

	}


	public void clickListner(){

		StartCoroutine ("clickEvent");
	}


	IEnumerator clickEvent()
	{


		yield return new WaitForSeconds (1.9f);
		speed = speed-2;


	}
}
