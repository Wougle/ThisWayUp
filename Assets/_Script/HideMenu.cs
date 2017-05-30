using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideMenu : MonoBehaviour {
	public GameObject menu;
	public GameObject mask;
	public GameObject tile;
	public GameObject player;
	// Use this for initialization
	void Start () {
		menu.gameObject.SetActive (false);
		mask.gameObject.SetActive (false);
		tile.gameObject.SetActive (true);
		player.gameObject.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void clickThePauseButton(){
		menu.gameObject.SetActive (true);
		mask.gameObject.SetActive (true);
		tile.gameObject.SetActive (false);
		player.gameObject.SetActive (false);
	}

	public void clickTheResumeButton(){
		menu.gameObject.SetActive (false);
		mask.gameObject.SetActive (false);
		tile.gameObject.SetActive (true);
		player.gameObject.SetActive (true);
	}
}
