using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enmey : MonoBehaviour {
    Rigidbody playerRigidbody2D;
    public	int Status; //狀態值
	public float Speed = 0f;
	float Timer = 0.0f;
    public int EnemyHp = 3;
    public Animator EnemyAnim;
    public GameObject collibox;
    public GameObject player;
    public Transform other;
    public float playdis = 0f;
    public GameObject ScenemannagerCtrl;



    // Use this for initialization
    void Start () {
        playerRigidbody2D = GetComponent<Rigidbody>();
        EnemyAnim = GetComponent<Animator>();
        EnemyAnim.SetInteger("Enemy", 0);
        Status = 0;
        
    }
	
	// Update is called once per frame
	void Update () {
		switch (Status) {
		case 0://待機
               //未偵測到主角
                if ( this.transform.position.x - player.transform.position.x < 5.0f ) {
                    EnemyAnim.SetInteger("Enemy", 3);
                    Timer = 0.0f;
                    Status = 3;    
                }
                     break;

		case 1://受傷
               //被主角打
               //Timer = Timer * Time.deltaTime;
                Timer = Timer + Time.deltaTime;
                if (Timer >= 1.0f) {
                    EnemyAnim.SetInteger("Enemy", 0);
                    Status = 0;
                }
                if (EnemyHp <= 0) {
                    EnemyAnim.SetInteger("Enemy", 2);
                    ScenemannagerCtrl = GameObject.Find("SceneCenter");
                    ScenemannagerCtrl.SendMessage("CounterToEnd");
                    this.gameObject.GetComponent<Collider>().enabled = false;
                    Status = 2;
                }
                break;

            case 2://死亡
                Timer = 0.0f;
                float destroyTime = 2f;
                if (Time.time +destroyTime< Timer)
                {
                    Destroy(this.gameObject);
                }                 
                this.GetComponent<Collider>().enabled=false;
                

          
               

                    break;

            case 3://攻擊
                Timer = Timer + Time.deltaTime;
                playdis  = Vector3.Distance(other.position, transform.position);
                if (playdis < 2.0f) {
                    EnemyAnim.SetInteger("Enemy", 0);
                    Status = 0;

                }
                 
                if (Timer > 1.5f) {
                    EnemyAnim.SetInteger("Enemy", 0);
                    Status = 0;
                }
                break;

      /*  
       *  case 4://移動
                Timer = Timer + Time.deltaTime;
                if (Timer > 0.5f) {
                    EnemyAnim.SetInteger("Enemy", 0);
                    Status = 0;
                }
                break;
                */


        }
    }

    

    void GetDamageMessage() {
        
            EnemyAnim.SetInteger("Enemy", 1);
            EnemyHp -= 1;
            Timer = 0.0f;
            Status = 1;
            Debug.Log("48484896");  
        
    }

    void GetColl() {
        Instantiate(collibox, this.transform.position, this.transform.rotation).SetActive(true);
        
    }    



}
