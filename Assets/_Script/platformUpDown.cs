using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformUpDown : MonoBehaviour {

	float radian = 0;
	public float perRadian = 0.03f;
	public float range = 0.8f;
	public float isUpDown = 1f;
	Vector3 oldPos;
	// Use this for initialization
	void Start () {
		oldPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		radian += perRadian;
		float dy = Mathf.Cos (radian) * range;
		transform.position = oldPos + new Vector3 (0, dy*isUpDown, 0);
	}
}
