using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {
	
	public float Boundary = 50; // distance from edge scrolling starts
	public float speed = 15f;

	private int theScreenWidth;
	private int theScreenHeight;

	// Use this for initialization
	void Start () {
		GetComponent<UnityEngine.Camera>().orthographicSize = (Screen.height / 32f / 2.0f); // 100f is the PixelPerUnit that you have set on your sprite. Default is 100.	
		
		theScreenWidth = Screen.width;
		theScreenHeight = Screen.height;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.mousePosition.x > theScreenWidth - Boundary)
		{
			float scale = (Input.mousePosition.x - (theScreenWidth - Boundary)) / Boundary;
			transform.Translate(new Vector3(scale * speed * Time.deltaTime,0,0));
		}
		
		if (Input.mousePosition.x < 0 + Boundary)
		{
			float scale = 1 - Input.mousePosition.x / Boundary;
			transform.Translate(new Vector3(scale * -speed * Time.deltaTime,0,0));
		}
		
		if (Input.mousePosition.y > theScreenHeight - Boundary)
		{
			float scale = (Input.mousePosition.y - (theScreenHeight - Boundary)) / Boundary;
			transform.Translate(new Vector3(0,scale * speed * Time.deltaTime,0));
		}
		
		if (Input.mousePosition.y < 0 + Boundary)
		{
			float scale = 1 - Input.mousePosition.y / Boundary;
			transform.Translate(new Vector3(0,scale * -speed * Time.deltaTime,0));
		}
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
