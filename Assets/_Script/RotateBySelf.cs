using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBySelf : MonoBehaviour {
	public float speed = 10F;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.forward,Time.deltaTime * speed,Space.World);
	}
}
