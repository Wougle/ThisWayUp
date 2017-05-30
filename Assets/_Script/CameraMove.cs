using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
	public Transform obj;
	public int distance = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Camera.main.transform.rotation = obj.rotation;  
		//Camera.main.transform.position = new Vector3 (gameObj.transform.position.x, gameObj.transform.position.y, gameObj.transform.position.z - 5);  
		//Camera.main.transform.position = gameObj.transform.position.normalized * (gameObj.transform.position.magnitude - 3);  
		//Camera.main.transform.position = gameObj.transform.position + gameObj.transform.rotation.eulerAngles.normalized * 5;  
		Camera.main.transform.position = obj.position;  
		Camera.main.transform.Translate (Vector3.back * distance);  

	}
}
