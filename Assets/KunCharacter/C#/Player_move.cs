using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour {
	Rigidbody playerRigidbody2D;
	public	int Status; //狀態值
	float Timer; 	//計時器
	public float speedX;
	public float horizontalDirection;
	const string HORIZONTAL = "Horizontal";
	public float xForce;
	float speedY;
	public float maxSpeedX;
    public GameObject AnimObject;
	Animator anim;
	public float yForce;
    public GameObject knifeCollider;






	// Use this for initialization
	void Start () {
		playerRigidbody2D = GetComponent<Rigidbody> ();
        anim = AnimObject.GetComponent<Animator>();
        knifeCollider.SetActive(false);
    }

	// Update is called once per frame
	void Update () {


		switch (Status) {
		case 0://待機   
			if ( Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.D)) {
				anim.SetInteger ("AniStatus", 1);
				Status = 1;
			}

			if ( Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.S)) {
				Status = 2;
			}
			if (Input.GetKeyDown (KeyCode.W)) {
				playerRigidbody2D.AddForce (Vector2.up * yForce,ForceMode.Impulse);
				anim.SetInteger ("AniStatus", 5);
				Status = 5;
			}

			if (Input.GetMouseButtonDown (2)) {
				Status = 8;
			}
			if (Input.GetMouseButtonDown (0)) {
                    knifeCollider.SetActive(true);
                    anim.SetInteger ("AniStatus", 3);
				Timer = 0.0f;
				Status = 3;
			}
			break;
		case 1://移動
			float AxisX = Input.GetAxis ("Horizontal");

			playerRigidbody2D.AddForce (new Vector2 (xForce * AxisX, 0));  

			speedX = playerRigidbody2D.velocity.x;
			float newSpeedX = Mathf.Clamp (speedX, -maxSpeedX, maxSpeedX);	
			playerRigidbody2D.velocity = new Vector2 (newSpeedX, playerRigidbody2D.velocity.y);

			if (AxisX > 0.0f ) {
				this.transform.rotation = Quaternion.Euler (0.0f, 0.0f, 0.0f);
			} else if(AxisX < 0.0f ) {
				//this.transform.Rotate (0.0f, 90.0f, 0.0f);
				this.transform.rotation = Quaternion.Euler (0.0f, -180.0f, 0.0f);
			}

			if (Input.GetKey (KeyCode.DownArrow)){
				Status = 2;
			}
			if ( AxisX == 0.0f ) {
				anim.SetInteger ("AniStatus", 0);
				Status = 0; 
			}
			if (Input.GetMouseButtonDown (2)) {
				Status = 8;
			}
			if (Input.GetMouseButtonDown (0)) {
                    anim.SetInteger("AniStatus", 3);
                    knifeCollider.SetActive(true);
                    Timer = 0.0f;
				Status = 3;
			}

			if (Input.GetKeyDown (KeyCode.W)) {
                    playerRigidbody2D.AddForce(Vector2.up * yForce, ForceMode.Impulse);
                    anim.SetInteger("AniStatus", 5);
                    Status = 5;
                }

			break;
		case 2://蹲下      
			//放開方向鍵下後變成站立
			if(!Input.GetKey(KeyCode.DownArrow)){
				Status = 4;
			}
			break;

		case 3://攻擊   
			//按下滑鼠左鍵可攻擊


			if (!Input.GetMouseButtonDown (0)) {
                   
                    
				Timer = Timer + Time.deltaTime;
				if (Timer > 0.2f) {
					Status = 0;
                        knifeCollider.SetActive(false);
                        anim.SetInteger("AniStatus", 0);
                    }
                }
			break;


		case 4://站立      
			//站立完後回到待機
			if(!Input.GetKey(KeyCode.DownArrow)){
				Status = 0;
			}
			break;

		case 5://跳躍 
			if (playerRigidbody2D.velocity.y < 0 && this.transform.localPosition.y < 0.12) {
				anim.SetInteger ("AniStatus", 0);
				Status = 0;
			}
            
			break;

			//case 6://落下      
			//還不知道怎麼打
			//break;


		case 7://二段跳      
			//還不知道怎麼打

			break;

		case 8://防禦      
			//按下滑鼠右鍵可防禦
			if(!Input.GetMouseButtonDown (2)) {
				Status = 0;
			}
            

			break;

            case 9://受傷


                break;

		}
	}

	void OnCollisionEnter(Collision collision){
		if( ( Status == 6 ) && (collision.gameObject.tag == "Terrain") ){
			Status = 0;
		}
	}

}
