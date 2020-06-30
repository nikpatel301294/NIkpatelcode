using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;
public class Boss4Script : MonoBehaviour
{
    public SkeletonAnimation skeletonanimation;
    public AnimationReferenceAsset idle;
    public AnimationReferenceAsset fire;
    public AnimationReferenceAsset fireside;
    public string curruntString;

    public GameObject firobject;

    private int manageway;
    private int managcondition;
    private int animationmanage;
    public int bossHelth;
    public float bossHelthStore;
    public GameObject[] storeObject;

    public GameObject bossTouchPart;
    public GameObject boss1blastpart;
    public GameObject progressbar;

    [SerializeField]
    private Transform firepoint1;
    [SerializeField]
    private Transform firepoint2;
    [SerializeField]
    private Transform firepoint3;

    public int howmanypowerboss;
    private int storevalue;
    private int changevalue;
    public GameObject powerobject;

    Vector3 startPosition, endPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void setAnimation(AnimationReferenceAsset animation, bool loop, float timeScale)
    {
        skeletonanimation.state.SetAnimation(0, animation, loop).TimeScale = timeScale;
    }
    public void setcharacterState(string state)
    {
        if (state.Equals("normal"))
        {
            setAnimation(idle, true, 1f);
        }
        else if (state.Equals("fire"))
        {
            setAnimation(fire, true, 1f);
        }
        else if (state.Equals("fireside"))
        {
            setAnimation(fireside, true, 1f);
        }

    }
    void generate_Bullate()
    {
        SoundManagerScript.playsound("BossbullateSound");

        if (animationmanage == 0)
        {
            curruntString = "fire";
            setcharacterState(curruntString);
            InstantiateBullet(firepoint1.position.x, firepoint1.position.y);
            InstantiateBullet(firepoint2.position.x, firepoint2.position.y);
            InstantiateBullet(firepoint3.position.x, firepoint3.position.y);
        }
        else if (animationmanage == 1)
        {
            curruntString = "fireside";
            setcharacterState(curruntString);

            InstantiateBulletRotate(firepoint1.position.x, firepoint1.position.y, -0.02f);
            InstantiateBulletRotate(firepoint2.position.x, firepoint2.position.y, -0.2f);
            InstantiateBulletRotate(firepoint3.position.x, firepoint3.position.y, -0.2f);
        }



    }
    void InstantiateBullet(float x, float y)
    {
        startPosition = new Vector3(x, y, 0);
        endPosition = new Vector3(x, y - 10f, 0);

        firobject.GetComponent<bossbullateScipt>().startPosition = startPosition;
        firobject.GetComponent<bossbullateScipt>().targetPosition = endPosition;

        Instantiate(firobject, startPosition, Quaternion.identity);


    }

    void InstantiateBulletRotate(float x, float y, float z)
    {
        startPosition = new Vector3(x + z, y, 0);
        endPosition = new Vector3(x - x, y - 10f, 0);

        firobject.GetComponent<bossbullateScipt>().startPosition = startPosition;
        firobject.GetComponent<bossbullateScipt>().targetPosition = endPosition;

        Vector3 newDirection = (endPosition - startPosition);
        float i = newDirection.x;
        float j = newDirection.y;
        float rotationAngle = Mathf.Atan2(j, i) * 180 / Mathf.PI - 90f;
        firobject.transform.rotation = Quaternion.AngleAxis(rotationAngle, Vector3.down);

        Instantiate(firobject, startPosition, Quaternion.identity);

        Debug.Log("rotationfind" + firobject.transform.rotation);
    }
    void resetVaraible()
    {
        curruntString = "normal";
        setcharacterState(curruntString);
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
            if (changevalue == bossHelth)
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
                animationmanage = 0;
                Invoke("generate_Bullate", 2.3f);
                Invoke("generate_Bullate", 2.6f);
                Invoke("generate_Bullate", 2.9f);
                Invoke("plusVaraible", 4f);
                Invoke("resetVaraible", 4.5f);
            }
            if (gameObject.transform.position.Equals(storeObject[1].transform.position))
            {
                animationmanage = 0;
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
                animationmanage = 0;
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
                animationmanage = 1;
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
                animationmanage = 0;
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
                animationmanage = 1;
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
            progressbar.transform.localScale = new Vector3(bossHelth / bossHelthStore, 1f, 1f);
            //SoundManagerScript.playsound("bosstouchsoundcall");
            Destroy(other.gameObject);
            Vector3 storepostouch = new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y + 0.2f,
                    other.gameObject.transform.position.z);
            GameObject touchpart = Instantiate(bossTouchPart, storepostouch,
                   other.gameObject.transform.rotation);

            Destroy(touchpart, 0.5f);

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
