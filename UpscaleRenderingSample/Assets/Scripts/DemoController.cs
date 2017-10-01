using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.PostProcessing;

public class DemoController : MonoBehaviour {

	[SerializeField] Text modelLabel; 
	[SerializeField] Text rezLabel; 

	// Use this for initialization
	void Start () {
		modelLabel.text = "Device : " + SystemInfo.deviceModel + "  GPU : " + SystemInfo.graphicsDeviceName;
		rezLabel.text = Screen.width + " X " + Screen.height;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DownscaleRT( float scale) {
		DownscaleRT downscalert = Camera.main.GetComponent<DownscaleRT> ();
		downscalert.CreateRT (scale);
	}

	public void ToggleBloom() {
		PostProcessingBehaviour pps =  Camera.main.GetComponent<PostProcessingBehaviour> ();
		pps.enabled = !pps.enabled;
	}

	public void ToggleShadow() {
		if (QualitySettings.shadows != ShadowQuality.Disable)
			QualitySettings.shadows = ShadowQuality.Disable;
		else
			QualitySettings.shadows = ShadowQuality.All;
	}
}
