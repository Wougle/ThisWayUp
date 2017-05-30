using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BoxMove : MonoBehaviour {
	public GameObject moveTime;
	public float fAngle = 10.0f;
	int move = 0;
	public string sceneName;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//获取暂停按钮上的text
		Text text = moveTime.GetComponent<Button> ().transform.Find ("Text").GetComponent<Text> ();
		//获取箱子位置
		Vector3 player_postion = this.transform.position;
		//获取箱子大小
		Vector3 player_scale = this.transform.localScale;
		//获取纸箱速度
		float speed = GetComponent<Rigidbody> ().velocity.magnitude;

		//纸箱下落到y<=50时重启关卡
		if (player_postion.y <= 50) {
			SceneManager.LoadScene (sceneName);
		}

		//计算箱子位置
		float x = player_postion.x;

		float y = player_postion.y;

		float z = player_postion.z;

		//计算箱子大小
		float ylong = 7.5f;
			//player_scale.y;

			float xlong = 7.5f;
				//player_scale.x;

				float zlong = 7.5f;
					//player_scale.z;
		//当纸箱速度大于1时，不能操控
		if(speed < 1){
			if (Input.GetKeyDown(KeyCode.W))  
			{  
				//步数++
				move++;
				PlayerPrefs.SetInt (sceneName, move);//本地存储
				text.text = "move:" + move + "   ";
				//transform.Translate(1,0,0);  
				//float rightX = x - (float)0.5 * xlong;
				float rightY = y - (float)0.5 * ylong;
				float rightZ = z + (float)0.5 * zlong;
				Vector3 rotatePoint = new Vector3 (x, rightY, rightZ);
				transform.RotateAround(rotatePoint, Vector3.right, fAngle);
			}  
			if (Input.GetKeyDown(KeyCode.S))  
			{  
				//步数++
				move++;
				PlayerPrefs.SetInt (sceneName, move);//本地存储
				text.text = "move:" + move + "   ";
				//float rightX = x - (float)0.5 * xlong;
				float rightY = y - (float)0.5 * ylong;
				float rightZ = z - (float)0.5 * zlong;
				Vector3 rotatePoint = new Vector3 (x, rightY, rightZ);
				transform.RotateAround(rotatePoint, Vector3.left, fAngle); 
			}  
			if (Input.GetKeyDown(KeyCode.A))  
			{  
				//步数++
				move++;
				PlayerPrefs.SetInt (sceneName, move);//本地存储
				text.text = "move:" + move + "   ";
				float rightX = x - (float)0.5 * xlong;
				float rightY = y - (float)0.5 * ylong;
				//float rightZ = z - (float)0.5 * zlong;
				Vector3 rotatePoint = new Vector3 (rightX, rightY, z);
				transform.RotateAround(rotatePoint, Vector3.forward, fAngle); 
			}  
			if (Input.GetKeyDown(KeyCode.D))  
			{  
				//步数++
				move++;
				PlayerPrefs.SetInt (sceneName, move);//本地存储
				text.text = "move:" + move + "   ";
				float rightX = x + (float)0.5 * xlong;
				float rightY = y - (float)0.5 * ylong;
				//float rightZ = z - (float)0.5 * zlong;
				Vector3 rotatePoint = new Vector3 (rightX, rightY, z);
				transform.RotateAround(rotatePoint, Vector3.back, fAngle);
			}  
		}
	}

//	void OnCollisionEnter(Collision col) 
//	{
//		//进入碰撞器执行的代码
//		Debug.Log("Collision's name is "+ col.collider.name);
//	}
//
//	void OnCollisionStay(Collision col) 
//	{
//		//进入碰撞器执行的代码
//		Debug.Log("Collision's name is "+ col.collider.name);
//		Vector3 player_postion = this.transform.position;
//		transform.RotateAround(player_postion, Vector3.right, 360);
//	}
//
//	void OnCollisionExit(Collision col) 
//	{
//		//进入碰撞器执行的代码
//		Debug.Log("Collision's name is "+ col.collider.name);
//	}
		
}
