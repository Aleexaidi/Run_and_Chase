using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameSelection : MonoBehaviour {


	private GameObject[] nameList;
	private int index=0;
	private int player;
	// Use this for initialization


	void Start () {

	


		nameList = new GameObject[transform.childCount];

		for (int i = 0; i < transform.childCount; i++)
			nameList [i] = transform.GetChild (i).gameObject;

		foreach (GameObject go in nameList)
			go.SetActive (false);

		// toggle on first index

		if (nameList [index])
			nameList [index].SetActive (true);
	}

	public void ToggleLeft()
	{

		nameList [index].SetActive (false);
		index--;
		if (index < 0)
			index = nameList.Length - 1;

		nameList [index].SetActive (true);
	}

	public void ToggleRight()
	{

		nameList [index].SetActive (false);
		index++;
		if (index == nameList.Length)
			index = 0;

		nameList[index].SetActive (true);
	}

}
;