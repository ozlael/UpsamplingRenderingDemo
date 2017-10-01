using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof (Camera))]
public class DownscaleRT : MonoBehaviour {

	//[SerializeField] 
	RenderTexture rt;
	float ratio = 0.5f;
	[SerializeField]
	GameObject canvasForRT;
	//[SerializeField] 
	//RawImage targetImage;

	GameObject canvas;



	// Use this for initialization
	void Start () {
		
	}

	public void CreateRT( float scale) {
		ratio = scale;
		int w = (int)((float)Screen.width * ratio);
		int h = (int)((float)Screen.height * ratio);
		Debug.Log ( "Rez w : " + Screen.width + " h : " + Screen.height + "  w: " + w + "  h: " + h);

		rt = new RenderTexture(w, h, 24, RenderTextureFormat.DefaultHDR);
		rt.Create();
		GetComponent<Camera> ().targetTexture = rt;

		if( canvas == null)
			canvas = Instantiate (canvasForRT);
		RawImage raw = canvas.GetComponentInChildren<RawImage> ();
		raw.texture = rt;
	}

	public void ReleaseRT() {
		GetComponent<Camera> ().targetTexture = null;
		if( canvas != null)
			Destroy (canvas);
		if( rt != null)
			rt.Release ();
	}
	

	void OnEnable() {
		//CreateRT ();
	}

	void OnDisable() {
		ReleaseRT ();
	}
}
