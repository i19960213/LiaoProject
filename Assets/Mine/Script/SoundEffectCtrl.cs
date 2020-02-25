using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectCtrl : MonoBehaviour {
	public GameObject SoundE1;

	// Use this for initialization
	void Start () {
		GameObject.DontDestroyOnLoad (this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Z)){
			GameObject TempSe;
			TempSe = Instantiate (SoundE1);
			TempSe.SetActive (true);
		
	}
		if(Input.GetKeyDown(KeyCode.X)){
			GameObject TempSe;
			TempSe = Instantiate (SoundE1);
			TempSe.SetActive (true);

		}
}
}
