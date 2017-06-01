using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class ButtonAudioPlay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void PlaySound()
	{
		AudioSource SoundSource = new AudioSource ();

		AudioClip clip = Resources.Load("_Resource/_Audios/2.wav") as AudioClip;
		SoundSource.clip = clip;
		SoundSource.Play();
	}
}
