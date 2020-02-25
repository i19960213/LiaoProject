using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {
	public float Speed = 0f;
	float Timer = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position -= new Vector3 (1096.0f, 105.0f, 105.0f);


		
	}
}
