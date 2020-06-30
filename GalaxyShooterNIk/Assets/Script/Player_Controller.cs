using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Controller : MonoBehaviour
{

    public float min_X, max_X;
    public float min_Y, max_Y;
    public GameObject otherobject;
    public float speed = 5f;
    public bool checkpos;
    public Vector2 moveX;
    public GameObject callani;
    public GameObject powercover;
    GameObject runtimecover;
    public Vector3 startposition;
    public static int powerGenerate_manage;
    public static int planeDieManage;
    public static int powerprotectManage;
    [SerializeField]
    private GameObject player_Bullet;

    [SerializeField]
    private Transform []attack_Point;
  
    public float attack_Timer = 0.1f;
    private float current_Attack_Timer;
    private bool canAttack;
    public static int manageani;
    public Vector3 endposition;

    private Vector3 screenPoint;
    private Vector3 offset;
    public  Vector3 storeplayerpos;
    public static Player_Controller Instance;
    public int maangeplane;
    
    Vector3 startPosition, endPosition;

    // Start is called before the first frame update
    void Start()
    {
        powerGenerate_manage = 1;


        Instance = this;
        startposition = transform.position;
        endposition = new Vector3(-0.03f,- 3.32f,0f);
        current_Attack_Timer = attack_Timer;
        Invoke("Callplayer", 3.0f);

        //if (gameObject.CompareTag("Player"))
        //{
        //    gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Lv_5_Plane");
        //    gameObject.transform.localScale = new Vector3(0.6f,0.6f,0.6f);
        //    //gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Galxy_Plane_1");
        //}

        //if (gameObject.CompareTag("Player1"))
        //{
        //    gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Lv_5_Plane");
        //}
        //if (gameObject.CompareTag("Player2"))
        //{
        //    gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Lv_9_Plne");

        //}

        runtimecover = Instantiate(powercover, gameObject.transform.position,
                gameObject.transform.rotation);
        runtimecover.transform.parent = transform;
    }
    void Callplayer()
    {
        Invoke("destroyPlaneProtect", 5.0f);
        //InvokeRepeating("spawnTrail", 2.0f, 0.15f);
        InvokeRepeating("Shoot", 2.0f, 0.2f);
        checkpos = true;
    }
   
    void destroyPlaneProtect()
    {
        if (powercover!=null)
        {
            Destroy(runtimecover);
            //runtimecover.SetActive(false);
            powerprotectManage = 1;
           // GameObject.FindWithTag("planeProtectCircle").SetActive(false);
        }
    }
    void OnMouseDown()
    {
        Debug.Log("manageani" + manageani);

        //if (GameObject.FindWithTag("planeProtectCircle") != null)
        //{
        //    Destroy(GameObject.FindWithTag("planeProtectCircle"));
        //}


        if (manageani == 0)
        {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }
    }
    void OnMouseDrag()
    {
        if (manageani == 0)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
            transform.position = curPosition;
            storeplayerpos = transform.position;
            Debug.Log("stoefvwlaue" + storeplayerpos);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (checkpos == true)
        {
            gameObject.transform.localPosition = Vector3.MoveTowards(gameObject.transform.localPosition, otherobject.transform.localPosition, speed * Time.deltaTime);
            maangeplane = 1;
        }

    }

    //void spawnTrail()
    //{
        
    //    checkpos = false;

    //    if (manageani == 0)
    //    {
    //        Debug.Log("bulle123");

    //        if (powerGenerate_manage == 0)
    //        {
    //            SoundManagerScript.playsound("Plane1Fire");
    //            // gameobject.getcomponent<spriterenderer>().sprite = resources.load<sprite>("galxy_plane_1");
    //            Instantiate(player_Bullet, attack_Point[0].position, Quaternion.identity);
    //        }
    //        else if (powerGenerate_manage == 1)
    //        {
    //            SoundManagerScript.playsound("Plane1Fire");
    //            Instantiate(player_Bullet, attack_Point[3].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[4].position, Quaternion.identity);

    //        }
    //        else if (powerGenerate_manage == 2)
    //        {
    //            SoundManagerScript.playsound("Plane1Fire");
    //            Instantiate(player_Bullet, attack_Point[0].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[1].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[2].position, Quaternion.identity);
    //        }
    //        else if (powerGenerate_manage == 3)
    //        {
    //            SoundManagerScript.playsound("Plane1Fire");
    //            Instantiate(player_Bullet, attack_Point[1].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[2].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[3].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[4].position, Quaternion.identity);

    //        }


    //        else if (powerGenerate_manage == 4)
    //        {
    //            SoundManagerScript.playsound("Plane1Fire");
    //            Instantiate(player_Bullet, attack_Point[1].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[2].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[3].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[4].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[5].position, Quaternion.identity);
    //        }
    //        else if (powerGenerate_manage == 5)
    //        {
    //            SoundManagerScript.playsound("Plane1Fire");
    //            Instantiate(player_Bullet, attack_Point[1].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[2].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[3].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[4].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[5].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[6].position, Quaternion.identity);
    //        }
    //        else if (powerGenerate_manage == 6)
    //        {
    //            SoundManagerScript.playsound("Plane1Fire");
    //            Instantiate(player_Bullet, attack_Point[1].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[2].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[3].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[4].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[5].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[6].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[7].position, Quaternion.identity);
    //        }
    //        else if (powerGenerate_manage == 7)
    //        {
    //            SoundManagerScript.playsound("Plane1Fire");
    //            Instantiate(player_Bullet, attack_Point[1].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[2].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[3].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[4].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[5].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[6].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[7].position, Quaternion.identity);
    //            Instantiate(player_Bullet, attack_Point[8].position, Quaternion.identity);
    //        }
    //    }

    //    //laseraudio.Play();


    //}

    //void stopAnimation()
    //{
    //    GetComponent<Animator>().enabled = false;
    //    Destroy(gameObject);
    //    callretray();
       
    //}
    void resetPower()
    {
        powerGenerate_manage = PlayerPrefs.GetInt("powerGenerateString");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (powerprotectManage == 1 && manageani==0)
        {
            
            if ((other.CompareTag("EnemyTag")  || other.CompareTag("EnemyTag1") || other.CompareTag("EnemyTag2") ||
                other.CompareTag("EnemyTag3") || other.CompareTag("EnemyTag4") || other.CompareTag("EnemyTag5") || 
                other.CompareTag("EnemyTag6") || other.CompareTag("EnemyTag7") || other.CompareTag("Stone")))
                

            {

                manageani = 1;
                MoveEnemy.countDieEnemy++;
                Destroy(other.gameObject);

                GameObject[] bullates = GameObject.FindGameObjectsWithTag("BullateTag");
                foreach (GameObject enemy in bullates)
                    GameObject.Destroy(enemy);

                //GameObject[] enemybullates = GameObject.FindGameObjectsWithTag("EnemyBullate");
                //foreach (GameObject enemynew in enemybullates)
                //    GameObject.Destroy(enemynew);

                gameObject.GetComponent<Animator>().enabled = true;

                if (GameObject.Find("Ship1fireani") != null)
                {
                    GameObject.Find("Ship1fireani").GetComponent<SpriteRenderer>().enabled = false;
                    GameObject.Find("Ship1fireani1").GetComponent<SpriteRenderer>().enabled = false;
                }
               
                Destroy(runtimecover);
                gameObject.GetComponent<Animator>().transform.localScale = new Vector3(1f, 1f, 1f);
                SoundManagerScript.playsound("BombSound");
                Invoke("callretray", 3.0f);

            }

            else if (other.CompareTag("EnemyBullate"))

            {

                manageani = 1;
               
                Destroy(other.gameObject);

                GameObject[] bullates = GameObject.FindGameObjectsWithTag("BullateTag");
                foreach (GameObject enemy in bullates)
                    GameObject.Destroy(enemy);

                GameObject[] enemybullates = GameObject.FindGameObjectsWithTag("EnemyBullate");
                foreach (GameObject enemynew in enemybullates)
                    GameObject.Destroy(enemynew);

                gameObject.GetComponent<Animator>().enabled = true;

                if (GameObject.Find("Ship1fireani") != null)
                {
                    GameObject.Find("Ship1fireani").GetComponent<SpriteRenderer>().enabled = false;
                    GameObject.Find("Ship1fireani1").GetComponent<SpriteRenderer>().enabled = false;
                }

                Destroy(runtimecover);
                gameObject.GetComponent<Animator>().transform.localScale = new Vector3(1f, 1f, 1f);
                SoundManagerScript.playsound("BombSound");
                Invoke("callretray", 3.0f);

            }

            else if (other.CompareTag("BossTag"))
            {

                manageani = 1;
                //MoveEnemy.countDieEnemy++;
               // Destroy(other.gameObject);

                GameObject[] bullates = GameObject.FindGameObjectsWithTag("BullateTag");
                foreach (GameObject enemy in bullates)
                    GameObject.Destroy(enemy);

                GameObject[] enemybullates = GameObject.FindGameObjectsWithTag("EnemyBullate");
                foreach (GameObject enemynew in enemybullates)
                    GameObject.Destroy(enemynew);

                gameObject.GetComponent<Animator>().enabled = true;

                if (GameObject.Find("Ship1fireani") != null)
                {
                    GameObject.Find("Ship1fireani").GetComponent<SpriteRenderer>().enabled = false;
                    GameObject.Find("Ship1fireani1").GetComponent<SpriteRenderer>().enabled = false;
                }

                Destroy(runtimecover);
                gameObject.GetComponent<Animator>().transform.localScale = new Vector3(1f, 1f, 1f);
                SoundManagerScript.playsound("BombSound");
                Invoke("callretray", 3.0f);

            }
        }

        if(manageani==0)
        {

            if (other.CompareTag("powerTag"))
            {
                SoundManagerScript.playsound("PowerSound");
                Destroy(other.gameObject);
                powerGenerate_manage++;

            }
            if (other.CompareTag("MultipowerTag"))
            {
                PlayerPrefs.SetInt("powerGenerateString", powerGenerate_manage);
                SoundManagerScript.playsound("PowerSound");
                Destroy(other.gameObject);
                powerGenerate_manage = 12;
                Invoke("resetPower", 8.0f);
            }
            if (other.CompareTag("ProtectpowerTag"))
            {
                SoundManagerScript.playsound("PowerSound");
                Destroy(other.gameObject);

                runtimecover = Instantiate(powercover, gameObject.transform.position,
                    gameObject.transform.rotation);
                runtimecover.transform.parent = transform;
                powerprotectManage = 0;
                Invoke("destroyPlaneProtect", 5.0f);
            }

        }


    }
    void callretray()
    {
        gameObject.SetActive(false);
        //Time.timeScale = 0;
        // PlayerPrefs.SetInt("LevelStore", SceneManager.GetActiveScene().buildIndex);
        Debug.Log("callretray");
        //HelthScore.helthCount = 3;
        SceneManager.LoadScene("ResumeLevel", LoadSceneMode.Additive);

    }
    public void PlaneGenerate()
    {
        if(PlayerPrefs.GetInt("whichplaneSelectStore")==1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("ship1");
        }
        if (PlayerPrefs.GetInt("whichplaneSelectStore") == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("ship2");
        }
        if (PlayerPrefs.GetInt("whichplaneSelectStore") == 3)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("ship3");
        }
        if (PlayerPrefs.GetInt("whichplaneSelectStore") == 4)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("ship4");
        }
        if (PlayerPrefs.GetInt("whichplaneSelectStore") == 5)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("ship5");
        }
        gameObject.GetComponent<Animator>().enabled = false;
        //gameObject.SetActive(true);
        gameObject.transform.localPosition = Vector3.MoveTowards(gameObject.transform.localPosition, otherobject.transform.localPosition, speed * Time.deltaTime);
        gameObject.transform.localPosition = otherobject.transform.localPosition;
        gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        powerprotectManage = 0;
        //powerGenerate_manage = 1;

        // gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("ship2");

        PlaneManage.instance.falseallPlane();
        PlaneManage.instance.totolPlaneobject[(PlayerPrefs.GetInt("whichplaneSelectStore")) - 1].SetActive(true);


        //gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Galxy_Plane_1");

        manageani = 0;
        runtimecover = Instantiate(powercover, gameObject.transform.position,
                 gameObject.transform.rotation);
        runtimecover.transform.parent = transform;
        Invoke("destroyPlaneProtect", 5.0f);
        //GameObject.FindWithTag("planeProtectCircle").SetActive(true);
    }

    void Shoot()
    {
        checkpos = false;
        Debug.Log("powerGenerate_manage"+ powerGenerate_manage);
        if (powerGenerate_manage > 12)
        {
            powerGenerate_manage = 12;
        }
            if (manageani == 0)
        {
            //		value = 11;
           
            switch (powerGenerate_manage)
            {

                case 1:
                    SoundManagerScript.playsound("PlaneFireSound1");
                    InstantiateBullet(0, 0.6f);
                    break;
                case 2:
                    SoundManagerScript.playsound("PlaneFireSound2");
                    InstantiateBullet(0.08f, 0.6f);
                    InstantiateBullet(-0.08f, 0.6f);
                    break;
                case 3:
                    SoundManagerScript.playsound("PlaneFireSound3");
                    InstantiateBullet(0.15f, 0.5f);
                    InstantiateBullet(-0.15f, 0.5f);
                    //
                    InstantiateBullet(0, 0.6f);
                    break;
                case 4:
                    //
                    SoundManagerScript.playsound("PlaneFireSound1");
                    InstantiateBulletRotate(1.1f, 0.6f, 0);
                    InstantiateBulletRotate(-1.1f, 0.6f, 0);
                    //
                    InstantiateBullet(0, 0.6f);
                    break;
                case 5:
                    //
                    SoundManagerScript.playsound("PlaneFireSound2");
                    InstantiateBulletRotate(1.8f, 0.6f, 0);
                    InstantiateBulletRotate(-1.8f, 0.6f, 0);
                    //
                    InstantiateBulletRotate(0.6f, 0.6f, 0);
                    InstantiateBulletRotate(-0.6f, 0.6f, 0);
                    break;
                case 6:
                    SoundManagerScript.playsound("PlaneFireSound3");
                    InstantiateBulletRotate(2.4f, 0.6f, 0);
                    InstantiateBulletRotate(-2.4f, 0.6f, 0);
                    //
                    InstantiateBulletRotate(1.2f, 0.6f, 0);
                    InstantiateBulletRotate(-1.2f, 0.6f, 0);
                    //
                    InstantiateBullet(0, 0.6f);
                    break;
                case 7:
                    SoundManagerScript.playsound("PlaneFireSound1");
                    InstantiateBulletRotate(2.4f, 0.6f, 0);
                    InstantiateBulletRotate(-2.4f, 0.6f, 0);
                    //
                    InstantiateBulletRotate(1.2f, 0.6f, 0);
                    InstantiateBulletRotate(-1.2f, 0.6f, 0);
                    //
                    InstantiateBullet(0.1f, 0.6f);
                    InstantiateBullet(-0.1f, 0.6f);
                    break;
                case 8:
                    SoundManagerScript.playsound("PlaneFireSound2");
                    InstantiateBulletRotate(2.4f, 0.6f, 0);
                    InstantiateBulletRotate(-2.4f, 0.6f, 0);
                    //
                    InstantiateBulletRotate(1.2f, 0.6f, 0);
                    InstantiateBulletRotate(-1.2f, 0.6f, 0);
                    //
                    InstantiateBullet(0.15f, 0.6f);
                    InstantiateBullet(-0.15f, 0.6f);
                    //
                    InstantiateBullet(0, 0.6f);
                    break;
                case 9:
                    SoundManagerScript.playsound("PlaneFireSound2");
                    InstantiateBulletRotate(2.4f, 0.6f, 0);
                    InstantiateBulletRotate(-2.4f, 0.6f, 0);
                    //
                    InstantiateBulletRotate(1.283f, 0.6f, 0.083f);
                    InstantiateBulletRotate(1.117f, 0.6f, -0.083f);
                    //
                    InstantiateBulletRotate(-1.283f, 0.6f, -0.083f);
                    InstantiateBulletRotate(-1.117f, 0.6f, 0.083f);
                    //
                    InstantiateBullet(0.08f, 0.6f);
                    InstantiateBullet(-0.08f, 0.6f);
                    break;
                case 10:
                    SoundManagerScript.playsound("PlaneFireSound1");
                    InstantiateBulletRotate(2.486f, 0.6f, 0.086f);
                    InstantiateBulletRotate(2.314f, 0.6f, -0.086f);
                    //
                    InstantiateBulletRotate(-2.486f, 0.6f, -0.086f);
                    InstantiateBulletRotate(-2.314f, 0.6f, 0.086f);
                    //
                    InstantiateBulletRotate(1.283f, 0.6f, 0.083f);
                    InstantiateBulletRotate(1.117f, 0.6f, -0.083f);
                    //
                    InstantiateBulletRotate(-1.283f, 0.6f, -0.083f);
                    InstantiateBulletRotate(-1.117f, 0.6f, 0.083f);
                    //
                    InstantiateBullet(0.08f, 0.6f);
                    InstantiateBullet(-0.08f, 0.6f);
                    break;
                case 11:
                    SoundManagerScript.playsound("PlaneFireSound1");
                    InstantiateBulletRotate(3.086f, 0.6f, 0.086f);
                    InstantiateBulletRotate(2.914f, 0.6f, -0.086f);
                    //
                    InstantiateBulletRotate(-3.086f, 0.6f, -0.086f);
                    InstantiateBulletRotate(-2.914f, 0.6f, 0.086f);
                    //
                    InstantiateBulletRotate(1.882f, 0.6f, 0.082f);
                    InstantiateBulletRotate(1.718f, 0.6f, -0.082f);
                    //
                    InstantiateBulletRotate(-1.882f, 0.6f, -0.082f);
                    InstantiateBulletRotate(-1.718f, 0.6f, 0.082f);
                    //
                    InstantiateBulletRotate(0.68f, 0.6f, 0.08f);
                    InstantiateBulletRotate(0.52f, 0.6f, -0.08f);
                    //
                    InstantiateBulletRotate(-0.68f, 0.6f, -0.08f);
                    InstantiateBulletRotate(-0.52f, 0.6f, 0.08f);
                    break;
                case 12:
                    SoundManagerScript.playsound("PlaneFireSound3");
                    InstantiateBulletRotate(3.689f, 0.6f, 0.089f);
                    InstantiateBulletRotate(3.511f, 0.6f, -0.089f);
                    //
                    InstantiateBulletRotate(-3.689f, 0.6f, -0.089f);
                    InstantiateBulletRotate(-3.511f, 0.6f, 0.089f);
                    //
                    InstantiateBulletRotate(2.486f, 0.6f, 0.086f);
                    InstantiateBulletRotate(2.314f, 0.6f, -0.086f);
                    //
                    InstantiateBulletRotate(-2.486f, 0.6f, -0.086f);
                    InstantiateBulletRotate(-2.314f, 0.6f, 0.086f);
                    //
                    InstantiateBulletRotate(1.283f, 0.6f, 0.083f);
                    InstantiateBulletRotate(1.117f, 0.6f, -0.083f);
                    //
                    InstantiateBulletRotate(-1.283f, 0.6f, -0.083f);
                    InstantiateBulletRotate(-1.117f, 0.6f, 0.083f);
                    //
                    InstantiateBullet(0.08f, 0.6f);
                    InstantiateBullet(-0.08f, 0.6f);
                    break;
            }

        }
    }
    void InstantiateBullet(float x, float y)
    {
        startPosition = new Vector3(gameObject.transform.position.x + x, gameObject.transform.position.y + y + 0.1f, 0);
        endPosition = new Vector3(gameObject.transform.position.x + x, gameObject.transform.position.y + 10.5f, 0);

        player_Bullet.GetComponent<Bullet_Script>().startPosition = startPosition;
        player_Bullet.GetComponent<Bullet_Script>().targetPosition = endPosition;


        Instantiate(player_Bullet, startPosition, Quaternion.identity);

       
        Debug.Log("InstantiateBulletRotate" + endPosition);
    }

    void InstantiateBulletRotate(float x, float y, float z)
    {
        startPosition = new Vector3(gameObject.transform.position.x + z, gameObject.transform.position.y + y + 0.1f, 0);
        endPosition = new Vector3(gameObject.transform.position.x + x, gameObject.transform.position.y + 10.5f, 0);

        player_Bullet.GetComponent<Bullet_Script>().startPosition = startPosition;
        player_Bullet.GetComponent<Bullet_Script>().targetPosition = endPosition;

        Instantiate(player_Bullet, startPosition, Quaternion.identity);

       
        Vector3 newDirection = (endPosition - startPosition);
        float i = newDirection.x;
        float j = newDirection.y;
        float rotationAngle = Mathf.Atan2(j, i) * 180 / Mathf.PI - 90f;
        player_Bullet.transform.rotation = Quaternion.AngleAxis(rotationAngle, Vector3.forward);

       

    }
}
