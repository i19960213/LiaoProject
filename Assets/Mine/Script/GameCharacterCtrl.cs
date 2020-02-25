using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCharacterCtrl: MonoBehaviour {
	public float Spd = 0.1f;
	public float JumpForce = 5.0f;
	float Timer = 0.0f;
	int Status = 0;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		switch (Status) {
		case 0: //進場
			Timer = Timer + Time.deltaTime;
			this.Move ();
			break;
		case 1: //一般
			break;
		case 2: //受傷
			break;
		case 3: //死亡
			break;
		}
	}
		

		void Move () {
		
			if(Input.GetKey(KeyCode.D) ){
			this.transform.Translate (Spd*Time.deltaTime, 0.0f, 0.0f);
			}
			if(Input.GetKey(KeyCode.A) ){
			this.transform.Translate (-Spd*Time.deltaTime, 0.0f, 0.0f);
			}
		if(Input.GetKey(KeyCode.Space) ){
			this.transform.Translate (0.0f, JumpForce*Time.deltaTime, 0.0f);
		}
		}
	}



