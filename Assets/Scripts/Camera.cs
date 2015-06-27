using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<UnityEngine.Camera>().orthographicSize = (Screen.height / 32f / 2.0f); // 100f is the PixelPerUnit that you have set on your sprite. Default is 100.	
	}
}
