using UnityEngine;
using System.Collections;

public class DemoScript : MonoBehaviour {
    //name of the scene you want to load
    public string Level1Scene;
	public string OptionScene;
	public Color loadToColor = Color.white;
	
	// Update is called once per frame
	void OnGUI () {
        //Button to load the new scene
		if (GUI.Button (new Rect (500, 200, 100, 30), "Start")) {
			Initiate.Fade(Level1Scene,loadToColor,0.5f);	
		}
		if (GUI.Button(new Rect (500, 250,100,30),"Option")){
			Initiate.Fade(OptionScene,loadToColor,0.5f);
		}
		if (GUI.Button(new Rect (500, 300,100,30),"Quit")){
			Application.Quit();
			//Debug.Log("quit");
		}
	}
}
