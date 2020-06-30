using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss1Script : MonoBehaviour
{
    public GameObject firobject;
    private int manageway;
    private int managcondition;
    [SerializeField]
    private Transform firepoint;
    public int bossHelth;
    public float bossHelthStore;
    public GameObject [] storeObject;

    public GameObject bossTouchPart;
    public GameObject boss1blastpart;
    public GameObject progressbar;
    public int howmanypowerboss;
    private int storevalue;
    private int changevalue;
    public GameObject powerobject;
    // Start is called before the first frame update
    void Start()
    {
        if(howmanypowerboss>0)
        {
            storevalue = bossHelth / howmanypowerboss;
            changevalue = bossHelth- storevalue;
            if(changevalue<=0)
            {
                changevalue = 1;
            }
        }
       

       
        //gameObject.transform.position = storeObject[3].transform.position;
    }
    void generate_Bullate()
    {
        SoundManagerScript.playsound("BossbullateSound");
        Instantiate(firobject, firepoint.position, Quaternion.identity);
        
    }

    void resetVaraible()
    {
        managcondition = 0;
    }
    void plusVaraible()
    {
        manageway++;
    }
    
    // Update is called once per frame

    void Update()
    {
        if (Player_Controller.powerGenerate_manage < 12)
        {
            if(changevalue == bossHelth)
            {
                GameObject coinruntime = Instantiate(powerobject, gameObject.transform.position,
                          gameObject.transform.rotation);
                changevalue = changevalue + storevalue;
            }
        }

        if (managcondition == 0)
        {

            if (gameObject.transform.position.Equals(storeObject[0].transform.position))
            {
                Debug.Log("Second");
                //manageway = 1;
                managcondition = 1;
                
                Invoke("generate_Bullate",0.3f);
                Invoke("generate_Bullate", 0.6f);
                Invoke("generate_Bullate", 0.9f);
                Invoke("plusVaraible", 2f);
                Invoke("resetVaraible", 2.5f);
            }
            if (gameObject.transform.position.Equals(storeObject[1].transform.position))
            {
                Debug.Log("Second");
              
                if (manageway == 4)
                {
                    manageway = 5;
                }
                else if (manageway < 4)
                {
                    manageway = 2;
                }

            }
            if (gameObject.transform.position.Equals(storeObject[3].transform.position))
            {
                Debug.Log("Second");
                //manageway = 3;
                managcondition = 1;
                Invoke("generate_Bullate", 0.3f);
                Invoke("generate_Bullate", 0.6f);
                Invoke("generate_Bullate", 0.9f);
                Invoke("plusVaraible", 2f);
                Invoke("resetVaraible", 2.5f);
            }
            if (gameObject.transform.position.Equals(storeObject[2].transform.position))
            {
                Debug.Log("Second");
                //manageway = 4;
                managcondition = 1;
                Invoke("generate_Bullate", 0.3f);
                Invoke("generate_Bullate", 0.6f);
                Invoke("generate_Bullate", 0.9f);
                Invoke("plusVaraible", 2f);
                Invoke("resetVaraible", 2.5f);
            }
            if (gameObject.transform.position.Equals(storeObject[4].transform.position))
            {
                Debug.Log("Second");
                // manageway = 6;
                managcondition = 1;
                Invoke("generate_Bullate", 0.3f);
                Invoke("generate_Bullate", 0.6f);
                Invoke("generate_Bullate", 0.9f);
                Invoke("plusVaraible", 2f);
                Invoke("resetVaraible", 2.5f);
            }
            if (gameObject.transform.position.Equals(storeObject[5].transform.position))
            {
                Debug.Log("Second");
                manageway = 0;
                Invoke("generate_Bullate", 0.3f);
                Invoke("generate_Bullate", 0.6f);
                Invoke("generate_Bullate", 0.9f);
                managcondition = 1;
                
                // Invoke("plusVaraible", 2f);
                Invoke("resetVaraible", 2.5f);
            }

        }
        if (manageway == 0)
        {
            Debug.Log("first");
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, storeObject[0].transform.position, 2 * Time.deltaTime);

        }
        if (manageway == 1)
        {
            Debug.Log("first");
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, storeObject[1].transform.position, 2 * Time.deltaTime);

        }
        if (manageway == 2)
        {
            Debug.Log("first");
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, storeObject[3].transform.position, 2 * Time.deltaTime);

        }
        if (manageway == 3)
        {
            Debug.Log("first");
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, storeObject[2].transform.position, 2 * Time.deltaTime);

        }
        if (manageway == 4)
        {
            Debug.Log("first");
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, storeObject[1].transform.position, 2 * Time.deltaTime);

        }
        if (manageway == 5)
        {
            Debug.Log("first");
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, storeObject[4].transform.position, 2 * Time.deltaTime);

        }
        if (manageway == 6)
        {
            Debug.Log("first");
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, storeObject[5].transform.position, 2 * Time.deltaTime);

        }



    }

   
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("BullateTag"))
        {

            bossHelth--;
            progressbar.transform.localScale = new Vector3(bossHelth/ bossHelthStore, 1f,1f);
            //SoundManagerScript.playsound("bosstouchsoundcall");
            Destroy(other.gameObject);
            Vector3 storepostouch = new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y+0.2f,
                    other.gameObject.transform.position.z);
            GameObject touchpart = Instantiate(bossTouchPart , storepostouch,
                   other.gameObject.transform.rotation);

            Destroy(touchpart,0.5f);

            if (bossHelth == 0)
            {
                SoundManagerScript.playsound("BossblastSound");
                Destroy(gameObject);
                //GameObject[] bullates = GameObject.FindGameObjectsWithTag("EnemyBullate");
                //foreach (GameObject enemy in bullates)
                //    GameObject.Destroy(enemy);
                Vector3 storepos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,
                    gameObject.transform.position.z);
                GameObject zombiebloodnew = Instantiate(boss1blastpart, storepos,
                       gameObject.transform.rotation);

                //Invoke("calllevel",2f);
                //Destroy(zombiebloodnew);
                WaveManage.bossmanage = 1;
               
            }


        }
    }
}
