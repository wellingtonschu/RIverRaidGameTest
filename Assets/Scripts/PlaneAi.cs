using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneAi : MonoBehaviour 
{

	public float Velocidade = 3;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate(
			Velocidade * Input.GetAxis("Horizontal") * Time.deltaTime, 
			Velocidade * Input.GetAxis("Vertical") * Time.deltaTime, 
			0);
	}
}
