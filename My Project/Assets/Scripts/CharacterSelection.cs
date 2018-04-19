using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour {


	private GameObject[] characterList;
	private int index;

	private void Start(){


		index = 0;
		 
		characterList = new GameObject[transform.childCount];

		//fill array with models

		for (int i = 0; i < transform.childCount; i++)
			characterList [i] = transform.GetChild (i).gameObject;

		//toggle of renderer

		foreach (GameObject go in characterList)
			go.SetActive (false);

		// toggle on first index

		if (characterList [index])
			characterList [index].SetActive (true);
	}

	public void ToggleLeft()
	{

		characterList [index].SetActive (false);
		index--;
		if (index < 0)
			index = characterList.Length - 1;

		characterList [index].SetActive (true);
	}

	public void ToggleRight()
	{

		characterList [index].SetActive (false);
		index++;
		if (index == characterList.Length)
			index = 0;

		characterList [index].SetActive (true);
	}
		
	public void SelectButton()
	{
		
		PlayerPrefs.SetInt ("CharacterSelected", index);
//		Debug.Log (PlayerPrefs.GetInt ("CharacterSelected"));
		SceneManager.LoadScene("Opponent Select");
	}
}
;