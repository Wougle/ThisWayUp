using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class musicSlider : MonoBehaviour {
	AudioSource BGSound;
	public Slider VolumeSlider;
	// Use this for initialization
	void Start () {
		BGSound = FindObjectOfType (typeof(AudioSource))as AudioSource;
		VolumeSlider.value = BGSound.volume;
	}
	
	// Update is called once per frame
	void Update () {
		BGSound = FindObjectOfType (typeof(AudioSource))as AudioSource;
		BGSound.volume = VolumeSlider.value; 
		Debug.Log (BGSound.volume);

	}
}
