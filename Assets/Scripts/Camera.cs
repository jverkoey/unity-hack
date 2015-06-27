using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<UnityEngine.Camera>().orthographicSize = (Screen.height / 32f / 2.0f); // 100f is the PixelPerUnit that you have set on your sprite. Default is 100.	
	}
	
	// Update is called once per frame
	void Update () {
		float speed = 15f;
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.Translate(new Vector3(0,-speed * Time.deltaTime,0));
		}
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(new Vector3(0,speed * Time.deltaTime,0));
		}
	}
}
