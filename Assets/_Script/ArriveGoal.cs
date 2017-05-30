using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ArriveGoal : MonoBehaviour {
	public GameObject player3;//箱子
	public GameObject successMenu;//通关成功后的按钮
	public GameObject mask;//黑色背景
	public GameObject tile;//地
	public GameObject successMenuTitle;//通关成功后的成绩text

	public string sceneName;
	public string bestSceneName;

	int isCollision;
	int scale;
	// Use this for initialization
	void Start () {
		isCollision = 0;
		scale = 0;
		successMenu.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		//改变scale
		if (isCollision > 0 && scale < 300) {
			//变小
			player3.transform.localScale = new Vector3(300 - scale,300 - scale,300 - scale);
			scale = scale + 3;
			//旋转
			player3.transform.Rotate(Vector3.up,Time.deltaTime * 200,Space.World);

			//协程
			if (scale == 30) {
				StartCoroutine(PlayerAttack());
			}

		}
	}
		
	IEnumerator PlayerAttack()
	{
		yield return new WaitForSeconds(1.0f);
		successMenu.gameObject.SetActive(true);
		mask.gameObject.SetActive(true);
		tile.gameObject.SetActive(false);
		player3.gameObject.SetActive(false);
		successMenuTitle.GetComponent<Text> ().text = @"通关成绩："+PlayerPrefs.GetInt (sceneName,0);

		if (PlayerPrefs.HasKey (bestSceneName)) {
			if(PlayerPrefs.GetInt (sceneName,0) <= PlayerPrefs.GetInt (bestSceneName,0)){
				PlayerPrefs.SetInt (bestSceneName, PlayerPrefs.GetInt (sceneName,0));
			}
		} else {
			PlayerPrefs.SetInt (bestSceneName, PlayerPrefs.GetInt (sceneName,0));
		}
	}

	void OnCollisionStay(Collision col) 
	{
		//进入碰撞器执行的代码
		Debug.Log("Collision's name is "+ col.collider.name);
		//旋转
//		player3.transform.Rotate(Vector3.up,Time.deltaTime * 200,Space.World);

		//开始变小
		isCollision = 1;
	}
}
