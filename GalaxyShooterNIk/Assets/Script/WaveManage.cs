using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaveManage : MonoBehaviour
{
    public static int manage;
    public int managewaveaction;
    //public int totalwaves;
    
    public GameObject[] totolWavesobject;
    public GameObject[] moveobjectstore;
    public Sprite[] wavenumber;
    public  static int generate_bullate;
    public GameObject waveobject;
    public GameObject wavenumberobject;
    public  int waveTotal;
    public static int WaveIncrement;
    public static int bossmanage;

    public Transform storewavepos;
    public Transform numberpos1;
    public Transform numberpos2;

    public Transform storewaveposend;
    public Transform numberpos1end;
    public Transform numberpos2end;

    public Transform storewaveposstart;
    public Transform numberpos1start;
    public Transform numberpos2start;

    public GameObject middelline;

    // Start is called before the first frame update
    void Start()
    {

        //PlayerPrefs.SetInt("LevelStore", SceneManager.GetActiveScene().buildIndex);
        WaveIncrement =PlayerPrefs.GetInt("WaveIncrement");
        manage = PlayerPrefs.GetInt("manage");
       // MoveEnemy.controlplane = PlayerPrefs.GetInt("controlplane");
        MoveEnemy.countDieEnemy = PlayerPrefs.GetInt("countDieEnemy");
        SpawnChicken.thingyCount = PlayerPrefs.GetInt("thingyCount");
        Player_Controller.manageani = PlayerPrefs.GetInt("manageani");
        bossmanage = PlayerPrefs.GetInt("bossmanage");
      //  Player_Controller.powerGenerate_manage = PlayerPrefs.GetInt("powerGeneratemanage");
        Player_Controller.powerprotectManage = PlayerPrefs.GetInt("powerprotectManagestring");


        waveobject.SetActive(true);
        wavenumberobject.GetComponent<SpriteRenderer>().sprite = wavenumber[manage];
        WaveIncrement++;
        
    }

    void wavesIncrement()
    {
        Debug.Log("wavesIncrement121");

        //totalwaves++;
        if (manage < waveTotal)
        {
            generate_bullate = 0;

            if (manage == 1)
            {
                //MoveEnemy.controlplane = 0;
                totolWavesobject[0].SetActive(false);
                totolWavesobject[1].SetActive(true);
                WaveIncrement++;
            }
            if (manage == 2)
            {
                //MoveEnemy.controlplane = 10;
                totolWavesobject[1].SetActive(false);
                totolWavesobject[2].SetActive(true);
                WaveIncrement++;
            }
            if (manage == 3)
            {
               // MoveEnemy.controlplane = 10;
                totolWavesobject[2].SetActive(false);
                totolWavesobject[3].SetActive(true);
                WaveIncrement++;
            }
            if (manage == 4)
            {
                //MoveEnemy.controlplane = 10;
                totolWavesobject[3].SetActive(false);
                totolWavesobject[4].SetActive(true);
                WaveIncrement++;
            }
            if (manage == 5)
            {
                //MoveEnemy.controlplane = 0;
                totolWavesobject[4].SetActive(false);
                totolWavesobject[5].SetActive(true);
                WaveIncrement++;
            }
            if (manage == 6)
            {
               // MoveEnemy.controlplane = 10;
                totolWavesobject[5].SetActive(false);
                totolWavesobject[6].SetActive(true);
                WaveIncrement++;
            }
            if (manage == 7)
            {
                //MoveEnemy.controlplane = 10;
                totolWavesobject[6].SetActive(false);
                totolWavesobject[7].SetActive(true);
                WaveIncrement++;
            }
            if (manage == 8)
            {
                //MoveEnemy.controlplane = 0;
                totolWavesobject[7].SetActive(false);
                totolWavesobject[8].SetActive(true);
                WaveIncrement++;
            }
            if (manage == 9)
            {
                //MoveEnemy.controlplane = 0;
                totolWavesobject[8].SetActive(false);
                totolWavesobject[9].SetActive(true);
                WaveIncrement++;
            }
        }

    }
    // Update is called once per frame

    void wavemanage_function()
    {

        GameObject.Find("Wave").transform.position = storewaveposstart.position;
        GameObject.Find("Wavenumber").transform.position = numberpos1start.position;
        GameObject.Find("totalaveimg").transform.position = numberpos2start.position;
        
        managewaveaction = 2;
        middelline.SetActive(false);
    }
    void managewaveaction_function()
    {
        managewaveaction = 1;
        //Invoke("wavemanage_function", 1f);
    }
    

    void Update()
    {
        if(managewaveaction<2)
        {

            if (managewaveaction == 0)
            {
                GameObject.Find("Wave").transform.position = Vector3.MoveTowards(GameObject.Find("Wave").transform.position, storewavepos.position, 3f * Time.deltaTime);
                GameObject.Find("Wavenumber").transform.position = Vector3.MoveTowards(GameObject.Find("Wavenumber").transform.position, numberpos1.position, 3f * Time.deltaTime);
                GameObject.Find("totalaveimg").transform.position = Vector3.MoveTowards(GameObject.Find("totalaveimg").transform.position, numberpos2.position, 3f * Time.deltaTime);

                Vector3 storeruntimewave = new Vector3(GameObject.Find("Wave").transform.position.x, GameObject.Find("Wave").transform.position.y,
                      GameObject.Find("Wave").transform.position.z);

                Vector3 storeruntime = new Vector3(storewavepos.position.x, storewavepos.position.y,
                    storewavepos.position.z);

                if (storeruntimewave.Equals(storeruntime))
                {
                    Debug.Log("called0");
                    Invoke("managewaveaction_function", 0.2f);

                }

            }

            if (managewaveaction == 1)
            {
                GameObject.Find("Wave").transform.position = Vector3.MoveTowards(GameObject.Find("Wave").transform.position, storewaveposend.position, 3f * Time.deltaTime);
                GameObject.Find("Wavenumber").transform.position = Vector3.MoveTowards(GameObject.Find("Wavenumber").transform.position, numberpos1end.position, 3f * Time.deltaTime);
                GameObject.Find("totalaveimg").transform.position = Vector3.MoveTowards(GameObject.Find("totalaveimg").transform.position, numberpos2end.position, 3f * Time.deltaTime);

                Vector3 storeruntimewave = new Vector3(GameObject.Find("Wave").transform.position.x, GameObject.Find("Wave").transform.position.y,
                      GameObject.Find("Wave").transform.position.z);

                Vector3 storeruntime = new Vector3(storewaveposend.position.x, storewaveposend.position.y,
                    storewaveposend.position.z);

                if (storeruntimewave.Equals(storeruntime))
                {
                    Debug.Log("called0");
                    Invoke("wavemanage_function", 0.2f);

                }

            }

        }
       


      



        //if (GameObject.Find("Wave").transform.position.Equals(storewaveposend.position))
        //{
        //    Invoke("wavemanage_function", 0.5f);
        //}
        if (manage < waveTotal-1)
        {
            if (MoveEnemy.countDieEnemy > 0)
            {
                if (MoveEnemy.countDieEnemy == SpawnChicken.thingyCount && manage == 0 && generate_bullate == 0)
                {
                    Debug.Log("WaveComplate");

                    manage = 1;

                   // waveobject.SetActive(true);
                    wavenumberobject.GetComponent<SpriteRenderer>().sprite = wavenumber[manage];
                    middelline.SetActive(true);
                    managewaveaction = 0;
                    //Invoke("wavemanage_function", 2f);

                    generate_bullate = 1;
                    MoveEnemy.countDieEnemy = 0;
                    SpawnChicken.thingyCount = 0;
                    Invoke("wavesIncrement", 1.0f);


                }
                else if (MoveEnemy.countDieEnemy == SpawnChicken.thingyCount && manage == 1 && generate_bullate == 0)
                {
                    Debug.Log("WaveComplate");

                    manage = 2;

                    wavenumberobject.GetComponent<SpriteRenderer>().sprite = wavenumber[manage];
                    middelline.SetActive(true);
                    managewaveaction = 0;

                    generate_bullate = 1;
                    MoveEnemy.countDieEnemy = 0;
                    SpawnChicken.thingyCount = 0;
                    Invoke("wavesIncrement", 1.0f);

                }
                else if (MoveEnemy.countDieEnemy == SpawnChicken.thingyCount && manage == 2 && generate_bullate == 0)
                {
                    Debug.Log("WaveComplate");

                    manage = 3;

                    wavenumberobject.GetComponent<SpriteRenderer>().sprite = wavenumber[manage];
                    middelline.SetActive(true);
                    managewaveaction = 0;

                    generate_bullate = 1;
                    MoveEnemy.countDieEnemy = 0;
                    SpawnChicken.thingyCount = 0;
                    Invoke("wavesIncrement", 1.0f);

                }
                else if (MoveEnemy.countDieEnemy == SpawnChicken.thingyCount && manage == 3 && generate_bullate == 0)
                {
                    Debug.Log("WaveComplate");

                    manage = 4;

                    wavenumberobject.GetComponent<SpriteRenderer>().sprite = wavenumber[manage];
                    middelline.SetActive(true);
                    managewaveaction = 0;

                    generate_bullate = 1;
                    MoveEnemy.countDieEnemy = 0;
                    SpawnChicken.thingyCount = 0;
                    Invoke("wavesIncrement", 1.0f);
                }
                else if (MoveEnemy.countDieEnemy == SpawnChicken.thingyCount && manage == 4 && generate_bullate == 0)
                {
                    Debug.Log("WaveComplate");

                    manage = 5;

                    wavenumberobject.GetComponent<SpriteRenderer>().sprite = wavenumber[manage];
                    middelline.SetActive(true);
                    managewaveaction = 0;

                    generate_bullate = 1;
                    MoveEnemy.countDieEnemy = 0;
                    SpawnChicken.thingyCount = 0;
                    Invoke("wavesIncrement", 1.0f);
                }
                else if (MoveEnemy.countDieEnemy == SpawnChicken.thingyCount && manage == 5 && generate_bullate == 0)
                {
                    Debug.Log("WaveComplate");

                    manage = 6;

                    wavenumberobject.GetComponent<SpriteRenderer>().sprite = wavenumber[manage];
                    middelline.SetActive(true);
                    managewaveaction = 0;

                    generate_bullate = 1;
                    MoveEnemy.countDieEnemy = 0;
                    SpawnChicken.thingyCount = 0;
                    Invoke("wavesIncrement", 1.0f);
                }
                else if (MoveEnemy.countDieEnemy == SpawnChicken.thingyCount && manage == 6 && generate_bullate == 0)
                {
                    Debug.Log("WaveComplate");

                    manage = 7;

                    wavenumberobject.GetComponent<SpriteRenderer>().sprite = wavenumber[manage];
                    middelline.SetActive(true);
                    managewaveaction = 0;

                    generate_bullate = 1;
                    MoveEnemy.countDieEnemy = 0;
                    SpawnChicken.thingyCount = 0;
                    Invoke("wavesIncrement", 1.0f);
                }
                else if (MoveEnemy.countDieEnemy == SpawnChicken.thingyCount && manage == 7 && generate_bullate == 0)
                {
                    Debug.Log("WaveComplate");

                    manage = 8;

                    wavenumberobject.GetComponent<SpriteRenderer>().sprite = wavenumber[manage];
                    middelline.SetActive(true);
                    managewaveaction = 0;

                    generate_bullate = 1;
                    MoveEnemy.countDieEnemy = 0;
                    SpawnChicken.thingyCount = 0;
                    Invoke("wavesIncrement", 1.0f);
                }
                else if (MoveEnemy.countDieEnemy == SpawnChicken.thingyCount && manage == 8 && generate_bullate == 0)
                {
                    Debug.Log("WaveComplate");

                    manage = 9;

                    wavenumberobject.GetComponent<SpriteRenderer>().sprite = wavenumber[manage];
                    middelline.SetActive(true);
                    managewaveaction = 0;

                    generate_bullate = 1;
                    MoveEnemy.countDieEnemy = 0;
                    SpawnChicken.thingyCount = 0;
                    Invoke("wavesIncrement", 1.0f);
                }
                else if (MoveEnemy.countDieEnemy == SpawnChicken.thingyCount && manage == 9 && generate_bullate == 0)
                {
                    Debug.Log("WaveComplate");

                    manage = 10;

                    wavenumberobject.GetComponent<SpriteRenderer>().sprite = wavenumber[manage];
                    middelline.SetActive(true);
                    managewaveaction = 0;

                    MoveEnemy.countDieEnemy = 0;
                    SpawnChicken.thingyCount = 0;
                }
                
            }
            
        }

        if (WaveIncrement == waveTotal && MoveEnemy.countDieEnemy == ChickenControl.Instance.totalChickenCount && MoveEnemy.countDieEnemy > 0)
        {
            //SceneManager.LoadScene("level_completed", LoadSceneMode.Additive);

            Invoke("callLevel", 2f);
            //SceneManager.LoadScene("level_completed",LoadSceneMode.Additive);
            //Debug.Log("FinishNIOw");
            WaveIncrement = 100;
        }

        if (bossmanage == 1)
        {
            Invoke("callLevel", 2f);
            bossmanage = 3;
        }


        }

        void callLevel()
    {
        // Time.timeScale = 0;
        Player_Controller.manageani = 1;
        //levelcomplatecalled
        SceneManager.LoadScene("level_completed", LoadSceneMode.Additive);
    }

}

