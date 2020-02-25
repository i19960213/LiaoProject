using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewStartButtonCtrl : MonoBehaviour {

    public string Level1Scene;
    public string OptionScene;
    public Color loadToColor = Color.white;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   public void StartFunction() {
        Initiate.Fade(Level1Scene, loadToColor, 0.5f);
    }
    public void OptionFunction()
    {
        Initiate.Fade(OptionScene, loadToColor, 0.5f);
    }
    public void EndFunction()
    {
        Application.Quit();
    }
}

