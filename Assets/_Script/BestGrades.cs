using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BestGrades : MonoBehaviour {
	public GameObject selectText;
	public string bestSceneName;
	// Use this for initialization
	void Start () {
		//获取按钮上的text
		Text text = selectText.GetComponent<Text> ();
		if (PlayerPrefs.HasKey (bestSceneName)) {
			text.text = "最佳:" + PlayerPrefs.GetInt (bestSceneName, 0).ToString ();
		} else {
			text.text = "未通关";
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
