using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE_Control : MonoBehaviour {
	AudioSource SoundEffect1;
	// Use this for initialization
	void Start () {
		SoundEffect1 = this.GetComponent<AudioSource> ();
		Destroy (this.gameObject, SoundEffect1.clip.length + 0.1f);
	}
	
	// Update is called once per frame
	void Update () {
			//send
	}
}
