using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_Ctrl : MonoBehaviour {
	public int Status;
	// Use this for initialization
	void Start () {
		GameObject.DontDestroyOnLoad (this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		switch (Status) {
		case 0:
			
			break;
		case 1:
			break;
		case 2:
			break;
		case 3:
			break;
		}
	}
}
