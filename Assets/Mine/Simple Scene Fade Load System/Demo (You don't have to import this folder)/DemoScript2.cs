using UnityEngine;
using System.Collections;

public class DemoScript2 : MonoBehaviour {
	//name of the scene you want to load
	public string scene;
	public Color loadToColor = Color.white;

	// Update is called once per frame
	void OnGUI () {
		//Button to load the new scene
		if (GUI.Button (new Rect (500, 200, 100, 30), "BackToLevel")) {
			Initiate.Fade(scene,loadToColor,0.5f);	
		}
		/*
		 * if (GUI.Button(new Rect (500, 250,100,30),"Quit")){
			Application.Quit();
			//Debug.Log("quit");
		}
		*/
	}
}