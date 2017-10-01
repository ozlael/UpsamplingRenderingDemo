using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FPSDisplay : MonoBehaviour {

	[SerializeField]
	Text text;

	float frames = 0.0f;

	void Start() {
		StartCoroutine (UpdateText());
	}

	void Update()
	{
		frames++;
	}

	IEnumerator UpdateText()
	{
		while (true) {
			yield return new WaitForSeconds (1);
			text.text = "FPS : " + frames;
			frames = 0;
		}
	}
}
