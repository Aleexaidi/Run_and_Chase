using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpponentSelect : MonoBehaviour {

	private GameObject[] characterList1;
	private int player;

	private void Start(){





		player = 0;

		characterList1 = new GameObject[transform.childCount];

		//fill array with models

		for (int i = 0; i < transform.childCount; i++)
			characterList1 [i] = transform.GetChild (i).gameObject;

		//toggle of renderer

		foreach (GameObject go in characterList1)
			go.SetActive (false);

		// toggle on first index

		if (characterList1 [player])
			characterList1 [player].SetActive (true);
	}

	public void ToggleLeft()
	{

		characterList1 [player].SetActive (false);
		player--;
		if (player < 0)
			player = characterList1.Length - 1;

		characterList1 [player].SetActive (true);
	}

	public void ToggleRight()
	{

		characterList1 [player].SetActive (false);
		player++;
		if (player == characterList1.Length)
			player = 0;

		characterList1 [player].SetActive (true);
	}

	public void SelectButton()
	{
		PlayerPrefs.SetInt ("OpponentSelected", player);
		SceneManager.LoadScene("Location");
	}


}


;