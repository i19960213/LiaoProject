using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NewColorScript : MonoBehaviour {
    float Timer;
    Image ImageColor;
    public GameObject LevelCtrl;
    // Use this for initialization
    void Start () {
        Timer = 0.0f;
         ImageColor= GetComponent<Image>();
        LevelCtrl = GameObject.Find("SceneCenter");
    }
	
	// Update is called once per frame
	void Update () {
        Timer = Timer + Time.deltaTime;

        ImageColor.color = Color.Lerp(Color.black, Color.white, Timer*0.5f);

        if (Timer > 3.5f && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("File_Level");
        }
    }
}
