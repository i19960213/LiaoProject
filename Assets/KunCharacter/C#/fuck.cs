﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuck : MonoBehaviour {
    private float time = 0.0f;
   

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		 time = time + Time.deltaTime;
        if (time > 0.5f) {
            Destroy(this.gameObject);
        }
	}
}
