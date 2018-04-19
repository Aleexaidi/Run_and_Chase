using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayOffline : MonoBehaviour {

	public void PlayOfline(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
		public void DesertLocation()
		{
			SceneManager.LoadScene ("Desert Location");
		}

		public void LakeLocation()
		{
			SceneManager.LoadScene ("Lake Location");
		}
	}

