using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characterlist1 : MonoBehaviour {

	public GameObject[] characterList1;

	// Use this for initialization
	void Start () {

		characterList1 [PlayerPrefs.GetInt ("OpponentSelected")].SetActive (true);

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
