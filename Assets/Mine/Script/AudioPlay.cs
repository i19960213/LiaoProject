using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioPlay : MonoBehaviour {
	AudioSource BGMplayer;
	public int Status;
	public AudioClip[] BGMselecter;
	int BGMnum;


	// Use this for initialization
	void Start () {
		GameObject.DontDestroyOnLoad (this.gameObject);
		BGMplayer = this.GetComponent<AudioSource> ();
		BGMplayer.volume = 0;
		BGMplayer.Play ();
		BGMplayer.clip = BGMselecter [0];
		Status = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
		//if (Input.GetKey (KeyCode.G)) {
		//BGMplayer.clip = BGMselecter[6];
		//if(){}
		switch(Status){
		case 0:
			BGMplayer.volume += 0.3f * Time.deltaTime;
			if (BGMplayer.volume > 1) {
				BGMplayer.volume = 1;
				Status++;
			}

				break;
		case 1: //播放中 + 收到換首

		
			break;
		case 2: 
			BGMplayer.volume -= 0.3f * Time.deltaTime;
			if(BGMplayer.volume < 0){
				BGMplayer.volume = 0;
			}
			if(BGMplayer.volume == 0){
				BGMplayer.clip = BGMselecter [BGMnum];
				Status = 0;
			}
			break;

		}
	}
		void ChangeMusic( int Index ){
			BGMnum = Index;
			//接收到的數字 = BGMnum;
			Status=2;
	}
}

