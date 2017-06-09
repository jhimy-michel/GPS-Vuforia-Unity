using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour 
{
	public float deltarotation=30f;
	public float deltamove=10f;

	public Color color;
	// Use this for initialization
	void Start ()
	{
		//renderer.material.color=new Color(color);
	}
	
	// Update is called once per frame
	void Update () 
	{
		//time.deltatime nos dice que corra igual en todos los dispositivos
		rotate();
		movement ();
	}
	void rotate()
	{
		if(Input.GetKey(KeyCode.Q))
		{
			transform.Rotate (new Vector3(0f,-deltarotation,0f)*Time.deltaTime);
		}else if(Input.GetKey(KeyCode.E))
		{
			transform.Rotate (new Vector3(0f,deltarotation,0f)*Time.deltaTime);
		}

	}
	void movement()
	{
		if(Input.GetKey(KeyCode.W))
		{
			transform.Translate (Vector3.forward * deltamove * Time.deltaTime);
		}else if(Input.GetKey(KeyCode.S))
		{
			transform.Translate (Vector3.back * deltamove * Time.deltaTime);
		}else if(Input.GetKey(KeyCode.A))
		{
			transform.Translate (Vector3.left * deltamove * Time.deltaTime);
		}else if(Input.GetKey(KeyCode.D))
		{
			transform.Translate (Vector3.right * deltamove * Time.deltaTime);
		}
	}
		
}
