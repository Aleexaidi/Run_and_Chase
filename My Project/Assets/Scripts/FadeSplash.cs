﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeSplash : MonoBehaviour {

	public Image splashImage;
	public string loadLevel;

	IEnumerator Start()
	{
		splashImage.canvasRenderer.SetAlpha (0.0f);

		FadeIn ();
		yield return new WaitForSeconds (2.5f);
		FadeOut ();
		yield return new WaitForSeconds (2.5f);
		SceneManager.LoadScene (loadLevel);
	}

	void FadeIn()
	{
		splashImage.CrossFadeAlpha (1.0f, 2.5f, false);
}
	void FadeOut()
	{
		splashImage.CrossFadeAlpha (1.0f, 2.5f, false);
	}
}