using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour {

	public GameObject[] characterList;

	// Use this for initialization
	void Start () {

		characterList [PlayerPrefs.GetInt ("CharacterSelected")].SetActive (true);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
