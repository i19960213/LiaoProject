using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Level_Ctrl : MonoBehaviour {
	public GameObject BGMControl;
    public int MonsterCounter = 0;
    public string Level1Stage;
    public string Level1EndConScene;
    public Color loadToColor = Color.black;
    public Color loadToColor2 = Color.white;
    // Use this for initialization
    void Start () {
		GameObject.DontDestroyOnLoad (this.gameObject);
		SceneManager.LoadScene("MainMenu");


	}
	
	// Update is called once per frame
	void Update () {
		/*if(Input.GetKeyDown(KeyCode.O)) //條件需要抓場景名
		{BGMControl.SendMessage ("ChangeMusic", 6);}*/

        if (Input.GetKeyDown(KeyCode.Y))
            { MonsterCounter += 16; }
        EndGameScene();

	}
	void ConToStage( int Index ){
		if (Index == 1) {
            Initiate.Fade(Level1Stage, loadToColor2, 0.5f);
            BGMControl.SendMessage("ChangeMusic", 6);
        }
	}
    void CounterToEnd() {
        MonsterCounter+=1;
        
    
    }
    void EndToLogo() {
        SceneManager.LoadScene("LogoThankStage");
    }
    void EndGameScene()
    {
        if (MonsterCounter >= 16)
        {
            Initiate.Fade(Level1EndConScene, loadToColor, 0.5f);
            MonsterCounter = 0;
            Debug.Log(">16");
        }
    }
}
