using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;
public class RandomBullateEnemy : MonoBehaviour
{
    public SkeletonAnimation world4enemy1;
    public AnimationReferenceAsset world4enemy1normal;
    public AnimationReferenceAsset world4enemy1fire;

    public SkeletonAnimation world4enemy2;
    public AnimationReferenceAsset world4enemy2normal;
    public AnimationReferenceAsset world4enemy2fire;

    public SkeletonAnimation enemy3;
    public AnimationReferenceAsset enemy3normal;
    public AnimationReferenceAsset  enemy3fire;

    public SkeletonAnimation enemy4;
    public AnimationReferenceAsset enemy4normal;
    public AnimationReferenceAsset enemy4fire;

    public SkeletonAnimation enemy5;
    public AnimationReferenceAsset enemy5normal;
    public AnimationReferenceAsset enemy5fire;

    public SkeletonAnimation enemy6;
    public AnimationReferenceAsset enemy6normal;
    public AnimationReferenceAsset enemy6fire;

    public SkeletonAnimation enemy7;
    public AnimationReferenceAsset enemy7normal;
    public AnimationReferenceAsset enemy7fire;

    public string curruntString;


    public float timecount, timeSpawnBullet, minSpeedBullet, maxSpeedBullet;
    //timeSpawnBullet  Interval random test to spawn bullet of chicken
    public int rateSpawn, numberRandom;

    public GameObject[] bulletPrefab;
    public GameObject powerGenerate_prefabs;
    public int rateSpawnItem, rateSpawnPower, MaxPowerSpawn, SpawnedPower = 0;
   // public GameObject[] GunPrefab;
    public GameObject itemPrefab, PowerPrefab, chickenDieEF;
   
    int numberGetChild;
    int storerandompower;
    int storevalue1, storevalue2, storevalue3, storevalue4, storevalue5, storevalue6, storevalue7;
    public bool begin;
    // Start is called before the first frame update
    void Start()
    {
        storerandompower = Random.Range(1, 3);
        Debug.Log("storerandompower" + storerandompower);

    }
    
    void changeNormal1()
    {
        if (ChickenControl.Instance.chicken[storevalue1] != null)
        {
            ChickenControl.Instance.chicken[storevalue1].GetComponent<SkeletonAnimation>().AnimationName = "Normal";
        }
    }
    void changeNormal2()
    {
        if (ChickenControl.Instance.chicken[storevalue2] != null)
        {
            ChickenControl.Instance.chicken[storevalue2].GetComponent<SkeletonAnimation>().AnimationName = "nr";
        }
    }
    void changeNormal3()
    {
        if (ChickenControl.Instance.chicken[storevalue3] != null)
        {
            ChickenControl.Instance.chicken[storevalue3].GetComponent<SkeletonAnimation>().AnimationName = "normal";
        }
    }
    void changeNormal4()
    {
        if (ChickenControl.Instance.chicken[storevalue4] != null)
        {
            ChickenControl.Instance.chicken[storevalue4].GetComponent<SkeletonAnimation>().AnimationName = "opening_ani";
        }
    }
    void changeNormal5()
    {
        if (ChickenControl.Instance.chicken[storevalue5] != null)
        {
            ChickenControl.Instance.chicken[storevalue5].GetComponent<SkeletonAnimation>().AnimationName = "normal";
        }
    }
    void changeNormal6()
    {
        if (ChickenControl.Instance.chicken[storevalue6] != null)
        {
            ChickenControl.Instance.chicken[storevalue6].GetComponent<SkeletonAnimation>().AnimationName = "normal";
        }
    }
    void changeNormal7()
    {
        if (ChickenControl.Instance.chicken[storevalue7] != null)
        {
            ChickenControl.Instance.chicken[storevalue7].GetComponent<SkeletonAnimation>().AnimationName = "normal";
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (begin && (GameObject.FindGameObjectWithTag("Player")) && SpawnChicken.thingyCount==ChickenControl.Instance.totalChickenCount)
        {
            timecount += Time.deltaTime;
            if (timecount >= timeSpawnBullet)
            {
                numberRandom = Random.Range(0, (SpawnChicken.thingyCount-1));
                if (numberRandom < rateSpawn)
                {
                    if (gameObject.transform.childCount > 1)
                    {
                        numberGetChild = Random.Range(0, gameObject.transform.childCount);
                        if (gameObject.transform.GetChild(numberGetChild))
                            InstantiateBullet(gameObject.transform.GetChild(numberGetChild).transform.position);
                    }
                }
                timecount = 0;
            }
        }
    }

    
    void InstantiateBullet(Vector3 value)
    {
        
        Vector3 startPosition = new Vector3(value.x, value.y, 1);
        Vector3 endPosition = new Vector3(value.x, value.y - 10.5f, 1);

        int storerandombullate = Random.Range(0,bulletPrefab.Length-1);
        int storerandombullatechciken = Random.Range(0, ChickenControl.Instance.chicken.Length - 1);
        
        if (ChickenControl.Instance.chicken[storerandombullatechciken]!=null)
        {
            Vector3 storepos = ChickenControl.Instance.chicken[storerandombullatechciken].transform.position;

            if(ChickenControl.Instance.chicken[storerandombullatechciken].CompareTag("EnemyTag1"))
            {
                storevalue1 = storerandombullatechciken;
                ChickenControl.Instance.chicken[storerandombullatechciken].GetComponent<SkeletonAnimation>().AnimationName= "fire";
                Invoke("changeNormal1", 1f);
            }

            if (ChickenControl.Instance.chicken[storerandombullatechciken].CompareTag("EnemyTag2"))
            {
                storevalue2 = storerandombullatechciken;
                ChickenControl.Instance.chicken[storerandombullatechciken].GetComponent<SkeletonAnimation>().AnimationName = "fire";
                Invoke("changeNormal2", 1f);
            }
            if (ChickenControl.Instance.chicken[storerandombullatechciken].CompareTag("EnemyTag3"))
            {
                storevalue3 = storerandombullatechciken;
                ChickenControl.Instance.chicken[storerandombullatechciken].GetComponent<SkeletonAnimation>().AnimationName = "Fire";
                Invoke("changeNormal3", 1f);
            }
            if (ChickenControl.Instance.chicken[storerandombullatechciken].CompareTag("EnemyTag4"))
            {
                storevalue4 = storerandombullatechciken;
                ChickenControl.Instance.chicken[storerandombullatechciken].GetComponent<SkeletonAnimation>().AnimationName = "fire";
                Invoke("changeNormal4", 1f);
            }
            if (ChickenControl.Instance.chicken[storerandombullatechciken].CompareTag("EnemyTag5"))
            {
                storevalue5 = storerandombullatechciken;
                ChickenControl.Instance.chicken[storerandombullatechciken].GetComponent<SkeletonAnimation>().AnimationName = "fire";
                Invoke("changeNormal5", 1f);
            }
            if (ChickenControl.Instance.chicken[storerandombullatechciken].CompareTag("EnemyTag6"))
            {
                storevalue6 = storerandombullatechciken;
                ChickenControl.Instance.chicken[storerandombullatechciken].GetComponent<SkeletonAnimation>().AnimationName = "fire";
                Invoke("changeNormal6", 1f);
            }
            GameObject newBullet = Instantiate(bulletPrefab[storerandombullate], storepos,
                                 Quaternion.identity);
            // GameObject newBullet = bulletPrefab[Random.Range(0, 3)].Spawn(startPosition);
            newBullet.GetComponent<EnemyBullateDestroy>().speed = Random.Range(minSpeedBullet, maxSpeedBullet);
            newBullet.GetComponent<EnemyBullateDestroy>().startPosition = startPosition;
            newBullet.GetComponent<EnemyBullateDestroy>().targetPosition = endPosition;
        }
        
    }

    public void RandonItem(Vector3 positionChicken)
    {
        Vector3 startPosition = new Vector3(positionChicken.x, positionChicken.y, 1);
        Vector3 endPosition = new Vector3(positionChicken.x, positionChicken.y - 15, 1);

        int storerandombullatechpower = Random.Range(0, ChickenControl.Instance.chicken.Length - 1);

        if (SpawnedPower < MaxPowerSpawn && Random.Range(0, SpawnChicken.thingyCount - 1) <= rateSpawnPower)
        {
            Vector3 storepos = ChickenControl.Instance.chicken[storerandombullatechpower].transform.position;

            GameObject newBullet = Instantiate(PowerPrefab, storepos,
                                 Quaternion.identity);

            // GameObject newItem = PowerPrefab.Spawn(startPosition);
            newBullet.GetComponent<MoveItem>().startPosition = startPosition;
            newBullet.GetComponent<MoveItem>().targetPosition = endPosition;
            SpawnedPower++;

        }
        //else
        ////if (Random.Range(0, 100) <= rateSpawnItem)
        //{
        //    GameObject newItem;
        //    Vector3 storepos = ChickenControl.Instance.chicken[storerandombullatechpower].transform.position;
        //    int storepower = Random.Range(0,(GunPrefab.Length-1));
        //    newItem = Instantiate(GunPrefab[storepower], storepos, Quaternion.identity);

        //    newItem.GetComponent<MoveItem>().startPosition = startPosition;
        //    newItem.GetComponent<MoveItem>().targetPosition = endPosition;
        //}

    }

}
