using System.Collections;
using UnityEngine;

/// <summary>
/// Control chicken hunt
/// </summary>
public class ChickenControl : MonoBehaviour
{

    public GameObject ChickenHouse;
    public bool checkHunt, willSpawnBullet;
    public float timeHunt, timeBeginHunt = 2, HeSovy = 0.1f, HeSoElapse_time = 2f;
    public float methodeCallTime;
    public bool chickemoveControl;
    public GameObject[] chicken;
    public int totalChickenCount;
    //public GameObject storeObject;
    public  int controlplane;
    public GameObject multiplebullate_prefabs;
    public GameObject protect_prefabs;

    public bool protectpowermange;

    public  int howmanyPower;
   
    bool beginHunt;
    float timeCount;
    int chickenCount = 0;
    int manageconditon;
    int endenemymanage;

    public float[] leftStore;
    public float[] rightStore;
    bool permitPower;
    public static ChickenControl Instance;
    public bool enemyisattack;
    public float enemyattackSpeed;

    int storepowernumber;
    int randomchicken;
    int powermanage1,powermanage2;
    Vector3 storeruntime;
    // Use this for initialization

    void Start()
    {
        Instance = this;

        storepowernumber = Random.Range(0,2);
        randomchicken = Random.Range(0, (chicken.Length - 1));

    }
    void changeValue()
    {
        if (controlplane == 10 && manageconditon == 0)
        {

            for (int i = 0; i < chicken.Length; i++)
            {
                if (chicken[i] != null)
                {
                    leftStore[i] = chicken[i].transform.localPosition.x - 0.2f;
                    rightStore[i] = chicken[i].transform.localPosition.x + 0.2f;
                    Debug.Log("leftstore" + leftStore[i]);
                }

            }

            manageconditon = 1;
            DebugeClass.text.text = "managevalue1";
        }

        DebugeClass.text.text = "changeValueCalled";
        controlplane = 1;
        MoveEnemy.direction = -1;
        DebugeClass.text.text = "Finish";
    }
    // Update is called once per frame
    void Update()
    {
       

        if (chickemoveControl == true && permitPower==true)
        {
            if (storepowernumber == 0)
            {

                if (MoveEnemy.countDieEnemy == (randomchicken - 1))
                {
                    
                    if (powermanage1 == 0 && Player_Controller.powerGenerate_manage < 12)
                    {
                        Debug.Log("storepowernumber0");
                        GameObject generatepre = Instantiate(multiplebullate_prefabs, storeruntime,
                                     Quaternion.identity);
                        SoundManagerScript.playsound("PowerGenerateSound");
                        powermanage1 = 1;
                    }
                }
            }

            if (storepowernumber == 1)
            {
                if (MoveEnemy.countDieEnemy == (randomchicken - 1))
                {

                    if (powermanage2 == 0 && protectpowermange==false && Player_Controller.powerprotectManage==1)
                    {
                        Debug.Log("protect_prefabsgenertate");
                        GameObject generatepre = Instantiate(protect_prefabs, storeruntime,
                                         Quaternion.identity);
                        SoundManagerScript.playsound("PowerGenerateSound");
                        powermanage2 = 1;
                    }
                }
            }

        }

        if (SpawnChicken.thingyCount == totalChickenCount && controlplane==0)
        {
            
            if (chickemoveControl == true)
            {
                if(chicken[randomchicken] != null)
                {
                    float storeX = Random.Range(-2f,2f);
                    storeruntime = new Vector3(storeX, 
                        2.4f, chicken[randomchicken].transform.position.z);
                    //storeruntime = chicken[randomchicken].transform.position;
                    permitPower = true;
                }
                
            }
            Invoke("changeValue", methodeCallTime);
            controlplane = 10;
            
        }


        if (Player_Controller.manageani == 0 && manageconditon == 1)
        {
            Debug.Log("cacascascascascasc");

            if (enemyisattack==true)
            {

                if (chicken[2] != null && Player_Controller.Instance.maangeplane == 1)
                {
                    Debug.Log("checkfor2");
                    chicken[2].transform.position = Vector3.MoveTowards(chicken[2].transform.position, Player_Controller.Instance.storeplayerpos, enemyattackSpeed * Time.deltaTime);

                }
                else if (chicken[10] != null && Player_Controller.Instance.maangeplane == 1)
                {
                    Debug.Log("checkfor5");
                    chicken[10].transform.position = Vector3.MoveTowards(chicken[10].transform.position, Player_Controller.Instance.storeplayerpos, enemyattackSpeed * Time.deltaTime);

                }
                else if (chicken[18] != null && Player_Controller.Instance.maangeplane == 1)
                {
                    Debug.Log("checkfor5");
                    chicken[18].transform.position = Vector3.MoveTowards(chicken[18].transform.position, Player_Controller.Instance.storeplayerpos, enemyattackSpeed * Time.deltaTime);

                }
                else if (chicken[26] != null && Player_Controller.Instance.maangeplane == 1)
                {
                    Debug.Log("checkfor5");
                    chicken[26].transform.position = Vector3.MoveTowards(chicken[26].transform.position, Player_Controller.Instance.storeplayerpos, enemyattackSpeed * Time.deltaTime);

                }
            }

        }

        if (chickemoveControl==true)
        {
            if (controlplane == 1 && manageconditon == 1)
            {
                DebugeClass.text.text = "MovementCall";

                //if (totalChickenCount == 0)
                //{
                //    totalChickenCount = chicken.Length;
                //}

                for (int i = 0; i < chicken.Length; i++)
                {
                    if (chicken[i] != null)
                    {


                        switch (MoveEnemy.direction)
                        {
                            case -1:
                                // Moving Left

                                if (chicken[i].transform.position.x.Equals(leftStore[i]))
                                {
                                    Debug.Log("direction 1");
                                    MoveEnemy.direction = 1;
                                }
                                else
                                //if (chicken[i].transform.position.x > leftStore[i])
                                //if (chicken[i].transform.position.x > (leftStore[i]))
                                {
                                    Debug.Log("case -1:");
                                    //chicken[i].transform.GetComponent<Rigidbody2D>().velocity = new Vector2(-0.5f, GetComponent<Rigidbody2D>().velocity.y);

                                    chicken[i].transform.position = Vector3.MoveTowards(chicken[i].transform.position, new Vector3(leftStore[i], chicken[i].transform.position.y, chicken[i].transform.position.z), 0.2f * Time.deltaTime);



                                }

                                break;

                            case 1:

                                //Moving Right

                                //if (chicken[i].transform.position.x < (rightStore[i]))
                                if (chicken[i].transform.position.x < rightStore[i])
                                {
                                    Debug.Log("case 1:");
                                    // chicken[i].transform.GetComponent<Rigidbody2D>().velocity = new Vector2(0.5f, GetComponent<Rigidbody2D>().velocity.y);

                                    chicken[i].transform.position = Vector3.MoveTowards(chicken[i].transform.position, new Vector3(rightStore[i], chicken[i].transform.position.y, chicken[i].transform.position.z), 0.2f * Time.deltaTime);

                                }
                                if (chicken[i].transform.position.x.Equals(rightStore[i]))
                                {
                                    Debug.Log("direction -1");
                                    MoveEnemy.direction = -1;

                                }
                                break;
                        }
                    }
                }


            }
        }
        
        if (beginHunt)
        {
            Debug.Log("Start");
            timeCount += Time.deltaTime;

            ////////////////////////////////0.5f deltatime between 2 chicken hunt player//////////////////////////////////

            //if (timeCount > 0.5f)
            //{
            //    if (GameObject.Find("Player"))
            //    {
            //        if (chickenCount < 35)
            //        {
            //            while (!chicken[chickenCount] && chickenCount < 34)
            //            {
            //                chickenCount++;
            //            }
            //            if (chicken[chickenCount])
            //            {
            //                chicken[chickenCount].GetComponent<MoveEnemy>().checkInHunt = true;
            //                chicken[chickenCount].GetComponent<MoveEnemy>().ChickenHouse = ChickenHouse;
            //               // chicken[chickenCount].GetComponent<MoveEnemy>().ChickenStartHunt = ChickenStartHunt;
            //                chicken[chickenCount].GetComponent<MoveEnemy>().timeHunt = timeHunt;

            //                if (GameObject.Find("Player"))
            //                {
            //                    chicken[chickenCount].GetComponent<MoveEnemy>().moveparabol(
            //                        chicken[chickenCount].transform.position,
            //                        GameObject.Find("Player").transform.position,
            //                        timeHunt);
            //                }
            //            }
            //        }
            //        timeCount = 0;
            //        if (chickenCount < 35)
            //            chickenCount++;
            //    }
            //}
        }

    }

    
    public void MakeArrayWithChicken()
    {
        int max = ChickenHouse.transform.childCount;
        // Debug.Log("maasdasdasdasdasadsx" + max);
        //old 41
        if (max < 60)
            for (int i = 0; i < max; i++)
            {
                if (ChickenHouse.transform.GetChild(i).gameObject)
                {
                    ChickenHouse.transform.GetChild(i).GetComponent<MoveEnemy>().HeSovy = HeSovy;
                    ChickenHouse.transform.GetChild(i).GetComponent<MoveEnemy>().HeSoelapse_time = HeSoElapse_time;
                    chicken[i] = ChickenHouse.transform.GetChild(i).gameObject;
                   // leftStore[0] = ChickenHouse.transform.GetChild(0).gameObject.transform.localPosition.x;
                    Debug.Log("max" + max);
                }
            }

        StartCoroutine(WaitTime());
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(timeBeginHunt);
        if (checkHunt)
            beginHunt = true;
    }
}
