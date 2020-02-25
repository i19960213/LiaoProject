using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextScript : MonoBehaviour {
	public GameObject LevelCtrl;
	Text ConText;
	public int lenMath;
	public int Status;
	float Timer;
	int formnum;
	public string[] myTextForm;
	void Start () {
		Status = 0;
		Timer = 0.0f;
		lenMath = 0;
		formnum = 0;
		ConText = GetComponent<Text> ();
		LevelCtrl = GameObject.Find ("SceneCenter");

	}
	
	// Update is called once per frame
	void Update () {
		switch(Status){
		case 0:
			Timer = Timer + Time.deltaTime;
			Debug.Log (Timer);
			ConText.text = myTextForm[formnum].Substring (0, lenMath);
			if (lenMath < myTextForm[formnum].Length) {	
				if (Timer > 0.2f) {
					lenMath++;
					Timer = 0;
				}
			}
			if(Input.GetMouseButtonDown(0))
                {
				lenMath = 0;
				Timer = 0.0f;
				formnum++;
			}
			if(formnum > 6){
				Status++;
			}
		

		

			break;
		case 1:
			LevelCtrl.SendMessage ("ConToStage", 1);
			break;
		}
	}
}


