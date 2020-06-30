using UnityEngine;
using System.Collections.Generic;

public class Style1 : MonoBehaviour
{
    //public int wayPointSize = 2;
    public GameObject enemy1;
    GameObject localenemy1;
    public float Speed=10;
   // public int currentWaypoint;
    private  bool check;
    Vector3 endPosition;
    int comaplate;

    public List<GameObject> waypoints = new List<GameObject>();
    List<GameObject> localenemy1store = new List<GameObject>();

    //List<int> currentWaypoint = new List<int>();

    int[] currentWaypoint = new int[31];

    void Start()
    { 
       // waypoints = new GameObject[wayPointSize];

        waypoints.Add(GameObject.Find("30.9"));
        waypoints.Add(GameObject.Find("2.14"));
        waypoints.Add(GameObject.Find("2.9"));

        waypoints.Add(GameObject.Find("5.3"));
        waypoints.Add(GameObject.Find("7.3"));
        waypoints.Add(GameObject.Find("9.3"));
        waypoints.Add(GameObject.Find("11.3"));
        waypoints.Add(GameObject.Find("13.3"));

        waypoints.Add(GameObject.Find("5.6"));
        waypoints.Add(GameObject.Find("7.6"));
        waypoints.Add(GameObject.Find("9.6"));
        waypoints.Add(GameObject.Find("11.6"));
        waypoints.Add(GameObject.Find("13.6"));

        waypoints.Add(GameObject.Find("5.9"));
        waypoints.Add(GameObject.Find("7.9"));
        waypoints.Add(GameObject.Find("9.9"));
        waypoints.Add(GameObject.Find("11.9"));
        waypoints.Add(GameObject.Find("13.9"));

        waypoints.Add(GameObject.Find("5.12"));
        waypoints.Add(GameObject.Find("7.12"));
        waypoints.Add(GameObject.Find("9.12"));
        waypoints.Add(GameObject.Find("11.12"));
        waypoints.Add(GameObject.Find("13.12"));
         
        waypoints.Add(GameObject.Find("5.15"));
        waypoints.Add(GameObject.Find("7.15"));
        waypoints.Add(GameObject.Find("9.15"));
        waypoints.Add(GameObject.Find("11.15"));
        waypoints.Add(GameObject.Find("13.15"));

        //waypoints.Add(GameObject.Find("5.18"));
        //waypoints.Add(GameObject.Find("7.18"));
        //waypoints.Add(GameObject.Find("9.18"));
        //waypoints.Add(GameObject.Find("11.18"));
        //waypoints.Add(GameObject.Find("13.18"));

        //gameObject.transform.position = waypoints[0].gameObject.transform.position;
        //waypoints[0].transform.Find("enemy2");
        //waypoints[0].transform.position=GameObject.Find("enemy2").transform.position;
        // Random.Range(0, waypoints.Length);
        //gameManager = GameObject.Find("GameManager").GetComponent<GameManagerBehavior>();
        //Rigidbody2D instantiatedProjectile = Instantiate(rigidbodycreate, firetran.position, firetran.rotation);
        //instantiatedProjectile.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);

        if (localenemy1store.Count < 26)
        {
            InvokeRepeating("generate_enemy", 1f, 0.1f);
            
        }
       

       // GameObject.Find("enemy1").transform.position = waypoints[currentWaypoint].gameObject.transform.position;
    }
    void generate_enemy()
    {
        if (localenemy1store.Count < 25)
        {
            localenemy1 = Instantiate(enemy1, waypoints[0].gameObject.transform.position, waypoints[0].gameObject.transform.rotation);
            localenemy1store.Add(localenemy1);
            //Debug.Log("currentWaypoint[0]"+ currentWaypoint[0]);
        }

    }
    void Update()
    {

        for (int i = 0; i < localenemy1store.Count; i++)
        {
            
            localenemy1store[i].transform.position = Vector3.MoveTowards(localenemy1store[i].transform.position, waypoints[currentWaypoint[i] + 1].gameObject.transform.position, Time.deltaTime * Speed);

            if ((localenemy1store[i].transform.position == waypoints[currentWaypoint[i] + 1].transform.position) && currentWaypoint[i] < 1)
            {
                currentWaypoint[i] = ((currentWaypoint[i] + 1) % waypoints.Count);
               
            }

            if ((localenemy1store[i].transform.position == waypoints[currentWaypoint[i] + 1].transform.position) && currentWaypoint[i]==1)
            {
                currentWaypoint[i] = ((currentWaypoint[i] + 1) % waypoints.Count)+ comaplate;
                comaplate = comaplate + 1;
                Debug.Log("workcondition");
            }
        }

        

        //localenemy1.transform.position = Vector3.MoveTowards(localenemy1.transform.position, waypoints[currentWaypoint+1].gameObject.transform.position, Time.deltaTime * Speed);

        //Debug.Log("sdasdasdsasd" + currentWaypoint);

        //if ((localenemy1.transform.position == waypoints[currentWaypoint+1].transform.position) && currentWaypoint < 1)
        //{
        //    currentWaypoint = (currentWaypoint + 1) % waypoints.Count;
        //    Debug.Log("sdasdasdsasd" + waypoints.Count);
        //}




        //endPosition = new Vector3(waypoints[currentWaypoint + 1].transform.position.x,
        //                                 waypoints[currentWaypoint + 1].transform.position.y, 0);

        //    //if (gameObject.transform.position.Equals(endPosition))
        //    if (check==true)
        //    {
        //        Debug.Log("ifconditonwork");

        //    }
        //    if (check == false)
        //    {
        //        Debug.Log("elseconditonwork");

        //        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, endPosition, Speed * Time.deltaTime);

        //    }

        //    if (gameObject.transform.position.Equals(endPosition))
        //    {
        //        check = true;
        //        gameObject.transform.position = Vector3.MoveTowards(endPosition, waypoints[currentWaypoint + 2].transform.position, Speed * Time.deltaTime);
        //        // gameObject.transform.position = waypoints[currentWaypoint+2].gameObject.transform.position;
        //    }


        //if (gameObject.transform.position.Equals(waypoints[1].transform.position))
        //{
        //    Debug.Log("ifconditonwork");

        //    gameObject.transform.position = Vector3.MoveTowards(waypoints[1].transform.position, endPosition, Speed * Time.deltaTime);
        //}
        //else  if (!(gameObject.transform.position.Equals(waypoints[1].transform.position)))
        // {
        //     Debug.Log("elseconditonwork");


        // }

    }
    //void Update()
    //{

    //    //beginMove Move from Spawn position into Maps
    //    if (beginMove)
    //    {
    //        Vector3 endPosition = new Vector3(waypoints[currentWaypoint + 1].transform.position.x,
    //                                 waypoints[currentWaypoint + 1].transform.position.y, 0);

    //        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, endPosition, speed * Time.deltaTime);

    //        if (gameObject.transform.position.Equals(endPosition))
    //        {
    //            if (currentWaypoint < waypoints.Length - 2)
    //                currentWaypoint++;
    //            else
    //            {
    //                if (loop)
    //                    currentWaypoint = 0;
    //                else
    //                {
    //                    if (lastSpawnChicken)
    //                    {

    //                        GameObject.Find("ChickenHouse").GetComponent<Animator>().SetTrigger("move");
    //                    }
    //                    beginMove = false;
    //                }
    //                if (huntAlone)
    //                    beginHuntAlone = true;
    //            }
    //        }
    //    }

    //    //Check when it reaches the correct grid position, then chicken start animation,move
    //    if (checkInHunt)
    //    {
    //        if (ChickenHouse.transform.position.x < 0.2f && ChickenHouse.transform.position.x > -0.2f)
    //        {
    //            gameObject.transform.SetParent(ChickenStartHunt.transform);
    //            beginHunt = true;
    //            checkInHunt = false;
    //        }
    //    }

    //    //beginHunt Start hunting the player
    //    if (beginHunt)
    //    {
    //        if (transform.position.y > PlayerY)
    //        {
    //            transform.Translate((vx) * Time.deltaTime, (vy - 19.8f * elapse_time) * Time.deltaTime * HeSovy, 0);
    //            transform.position = new Vector3(transform.position.x, transform.position.y, -1);
    //            elapse_time += Time.deltaTime * HeSoelapse_time;
    //        }
    //        else
    //        {
    //            beginHunt = false;
    //            checkOutHunt = true;
    //        }
    //    }

    //    //Check when move correct position on Map,then Put them on ChickenHouse
    //    if (checkOutHunt)
    //    {
    //        Vector3 endPosition = new Vector3(waypoints[waypoints.Length - 1].transform.position.x,
    //            waypoints[waypoints.Length - 1].transform.position.y, 1);

    //        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, endPosition, speed * Time.deltaTime);

    //        if (gameObject.transform.position.Equals(endPosition))
    //        {
    //            if (ChickenHouse.transform.position.x < 0.01f && ChickenHouse.transform.position.x > -0.01f)
    //            {
    //                gameObject.transform.SetParent(ChickenHouse.transform);
    //                checkOutHunt = false;
    //            }
    //        }
    //    }

    //    //Hunting Player 
    //    if (huntAlone && beginHuntAlone)
    //    {
    //        if (GameObject.Find("Player"))
    //        {
    //            currentWaypoint = 0;
    //            waypoints[0] = gameObject;
    //            if (!Dot)
    //                Dot = new GameObject();
    //            Dot.transform.position = GameObject.Find("Player").transform.position;
    //            waypoints[1] = Dot;
    //            beginMove = true;
    //            beginHuntAlone = false;
    //        }
    //    }
    //}

    //public void moveparabol(Vector3 start, Vector3 end, float t)
    //{
    //    PlayerY = end.y;
    //    float x = (end.x - start.x);
    //    float y = (end.y - start.y);
    //    vx = x / t;
    //    vy = (y + 0.5f * 19.8f * t * t) / t;
    //    //		Debug.Log (vx + " " + vy);
    //}

    //void OnDestroy()
    //{
    //    if (Dot)
    //    {
    //        Dot.Recycle();
    //    }
    //}

    //public void ScoreAdd()
    //{

    //    gameManager.Checklucky += 1;
    //    gameManager.Score += scoreBonus;

    //}

    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        if (other.GetComponent<Player>().saveZone == false)
    //        {
    //            other.transform.parent.gameObject.SetActive(false);
    //            gameManager.LevelFailedUIController();
    //            gameManager.gameOver = true;

    //            Music.THIS.GetComponent<AudioSource>().Stop();
    //            FXSound.THIS.GetComponent<AudioSource>().Stop();
    //            FXSound.THIS.fxSound.PlayOneShot(FXSound.THIS.PlayerDie[Random.Range(0, 3)]);
    //            EF_PlayerDie.Spawn(other.transform.position);

    //        }
    //        else
    //        {
    //            other.GetComponent<Player>().saveZone = false;
    //            other.GetComponent<Player>().SaveZone.SetActive(false);
    //        }
    //        if (DecoInMain.CheckVibrate == 1)
    //        {
    //            Handheld.Vibrate();
    //        }
    //        if (gameObject.CompareTag("enemy"))
    //            gameObject.Recycle();
    //    }
    //}
}


