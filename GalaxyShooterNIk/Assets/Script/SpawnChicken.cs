using UnityEngine;
using System.Collections;
using UnityEngine.UI;


[System.Serializable]
public class Wave {
	public GameObject[] enemyPrefab;
	public int[] numberWave;
    
}

public class SpawnChicken : MonoBehaviour {

	public GameObject[]  waypoints,waypoints2, waypoints3, waypoints4,waypoints5,waypoints6,waypoints7;
    public GameObject [] storeobject;
    //public Transform planestore;
    public Wave waves;		//Number of chickens on the way
    
    public float timeBeginWaves = 0.5f;		//Wait time to start spawn chicken

	public float speedChicken;		//Moving speed of chickens on the way
	public int HeathChicken;

    public static SpawnChicken instance;

    //	private GameManagerBehavior gameManager;

    public static int thingyCount;

    bool check_NextWave = false;		//Variable checks the  between two waves spawn chicken
	public float timeSpawn;

    public GameObject ChickenHouse;

	public bool lastSpawnChicken,loop,huntAlone;		//Mark last chicken spawn, to find the last chicken spawn
	private int i = 0;


    void Start () {

        //gameManager = GameObject.Find("GameManager").GetComponent<GameManagerBehavior>();

        instance = this;

    }
	void OnEnable() 
	{
		i = 0;
		check_NextWave = false;
		StartCoroutine (WaitTimeBeginWave(timeBeginWaves));
//		gameManager.MaxWave = waves.enemyPrefab.Length;
	}

	void Update () {

        if (check_NextWave == true)

            //if (i<waves.enemyPrefab.Length )  //Number of chicken spawn i < Sum chicken can spawn

            if (i < waves.enemyPrefab.Length)  //Number of chicken spawn i < Sum chicken can spawn
            {
           
                GameObject newEnemy = Instantiate(waves.enemyPrefab[i], waves.enemyPrefab[i].transform.position, waves.enemyPrefab[i].transform.rotation);

                if (newEnemy.transform.position.Equals(waves.enemyPrefab[i].transform.position))
                {
                    //PlaneControl PlanenewControl = newEnemy.GetComponent<PlaneControl>();
                    //PlanenewControl.planestore[thingyCount] = newEnemy;

                    thingyCount++;
                    Debug.Log("thingyCount" + thingyCount);
                    
                }

                

                MoveEnemy MoveNewEnemy = newEnemy.GetComponent<MoveEnemy>();
                MoveNewEnemy.speed = speedChicken;

                if (MoveNewEnemy.Heath == 0)
                {
                    MoveNewEnemy.Heath = HeathChicken;
                }
                if (loop)
                    MoveNewEnemy.loop = true;

                if (huntAlone)
                    MoveNewEnemy.huntAlone = true;


                //Move all chicken in HouseChicken to move left right

                newEnemy.transform.SetParent(ChickenHouse.transform);


                switch (waves.numberWave[i])
                {
                    case 1:
                        MoveNewEnemy.waypoints = waypoints;
                        break;
                    case 2:
                        MoveNewEnemy.waypoints = waypoints2;
                        break;
                    case 3:
                        MoveNewEnemy.waypoints = waypoints3;
                        break;
                    case 4:
                        MoveNewEnemy.waypoints = waypoints4;
                        break;
                    case 5:
                        MoveNewEnemy.waypoints = waypoints5;
                        break;
                    case 6:
                        MoveNewEnemy.waypoints = waypoints6;
                        break;
                    case 7:
                        MoveNewEnemy.waypoints = waypoints7;
                        break;
                }

                check_NextWave = false;
                if ((i + 1) < waves.enemyPrefab.Length)
                    StartCoroutine(WaitBetween2Chicken());
                else
                {
                   // Debug.Log("nasjdansdjasnds");
                    //If last chicken spawn of last turn chicken in waves , so remarked
                    if (lastSpawnChicken==false)
                    {
                        Debug.Log("nasjdansdjasnds");
                        MoveNewEnemy.lastSpawnChicken = true;
                        //Report to levelmanager is spawned all chicken
                        //GameObject.Find ("LevelManager").GetComponent<LevelManager> ().spawnedAll = true;

                        //Move all spawn chicken into grid to control
                        GetComponentInParent<ChickenControl> ().MakeArrayWithChicken ();
                    }
                }
            }

    }
    IEnumerator WaitTimeBeginWave(float index)

    {
        yield return new WaitForSeconds(index);
        check_NextWave = true;
    }

    /// <summary>
    /// WaitBetween2Chicken
    /// </summary>
    /// <returns>The between2 chicken.</returns>
    ///

    IEnumerator WaitBetween2Chicken()
    {
        yield return new WaitForSeconds(timeSpawn);
        i++;
        check_NextWave = true;
    }
}
