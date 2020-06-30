using UnityEngine;
using System.Collections;

public class MoveEnemy : MonoBehaviour {
	[HideInInspector]
	public GameObject[] waypoints;
	public int currentWaypoint = 0, scoreBonus;
	public GameObject ChickenHouse;
	public  static int countDieEnemy;
	public GameObject powerGenerate_prefabs;
	
	public int Heath,ChickenValue;
	public GameObject blastpart;
	public GameObject stoneblastpart;
	public GameObject generateenemyrun;
	public GameObject coingenerate;
	public GameObject enemy3bullate, enemy4bullate, enemy5bullate, enemy6bullate;
	
	
	
	public float HeSovy ,HeSoelapse_time = 1.5f;
	public GameObject[] thingyToFind;
	public GameObject[] thingyToFind1;
	public GameObject[] thingyToFind2;
	public GameObject[] thingyToFind4;
	public GameObject[] thingyToFind5;
	public GameObject[] thingyToFind6;

	//lastSpawnChicken Marked the last chicken spawn
	//beginMove stop update when go to target position
	public bool lastSpawnChicken,beginMove = true,loop,huntAlone,beginHuntAlone;  //loop with waves of chicken loop
	public bool checkBullateGenerate;
	// Mark the location to find the player position and start moving to
	public bool beginHunt,checkInHunt,checkOutHunt;
	public float speed,timeHunt;  //Time to fly from chicken to player
	float vx, vy,PlayerY;
	private float elapse_time;
	
	int[] manage = new int[10];

	//public float delta = 0.5f;  // Amount to move left and right from the start point
	public float speedmove = 1f;
	private Vector2 startPos;
	public bool movecheck;
	private int maxDistance = 1;

	//private float [] maxDist;
	//private float [] minDist;
	public static float direction;
	public static int managecount;

	public float generateobjectpos;
	
	

	
	void Start () {

        gameObject.transform.position = waypoints [0].gameObject.transform.position;
	
	}

	void OnEnable(){
		
	}

	
	//void moveallobject()
	//{
	//	DebugeClass.text.text = "MovemethodeCalled";

	//	generateobjectpos = transform.position.x;
	//	direction = -1;
	//	movecheck = true;

	//	Debug.Log("moveallobjectmoveallobject");
		
	//	if (ChickenControl.Instance.controlplane == 0)
	//	{
	//		ChickenControl.Instance.controlplane = 10;


	//		Debug.Log("AllEnemyMoved");

	//		if (thingyToFind.Length > 0)
	//		{
	//			Invoke("generateBullateOfEnemy3", 1f);
	//		}
	//		if (thingyToFind4.Length > 0)
	//		{
	//			Invoke("generateBullateOfEnemy4", 1f);
	//		}
	//		if (thingyToFind5.Length > 0)
	//		{
	//			Invoke("generateBullateOfEnemy5", 1f);
	//		}
	//		if (thingyToFind6.Length > 0)
	//		{
	//			Invoke("generateBullateOfEnemy6", 1f);
	//		}

	//	}
	//}
	//void generateBullateOfEnemy6()
	//{
	//	if (Player_Controller.manageani == 0)
	//	{

	//		int store = Random.Range(0, thingyToFind6.Length - 1);

	//		if (thingyToFind6[store] != null)
	//		{
	//			Instantiate(enemy6bullate, thingyToFind6[store].transform.position, Quaternion.identity);
	//			Invoke("generateBullateOfEnemy6", 1f);
	//		}
	//		if (thingyToFind6[store] == null)
	//		{
	//			Debug.Log("CancelInvoke");
	//			CancelInvoke("generateBullateOfEnemy6");
	//			Invoke("generateBullateOfEnemy6", 0.1f);
	//		}

	//	}


	//	if (Player_Controller.manageani == 1)
	//	{
	//		CancelInvoke("generateBullateOfEnemy6");

	//	}
	//}
	//void generateBullateOfEnemy5()
	//{
	//	if (Player_Controller.manageani == 0)
	//	{

	//		int store = Random.Range(0, thingyToFind5.Length - 1);

	//		if (thingyToFind5[store] != null)
	//		{
	//			Instantiate(enemy5bullate, thingyToFind5[store].transform.position, Quaternion.identity);
	//			Invoke("generateBullateOfEnemy5", 1f);
	//		}
	//		if (thingyToFind5[store] == null)
	//		{
	//			Debug.Log("CancelInvoke");
	//			CancelInvoke("generateBullateOfEnemy5");
	//			Invoke("generateBullateOfEnemy5", 0.1f);
	//		}

	//	}


	//	if (Player_Controller.manageani == 1)
	//	{
	//		CancelInvoke("generateBullateOfEnemy5");

	//	}
	//}
	//void generateBullateOfEnemy4()
 //   {
	//	if (Player_Controller.manageani == 0)
	//	{

	//			int store = Random.Range(0, thingyToFind4.Length - 1);

	//			if (thingyToFind4[store] != null)
	//			{
	//				Instantiate(enemy4bullate, thingyToFind4[store].transform.position, Quaternion.identity);
	//				Invoke("generateBullateOfEnemy4", 1f);
	//			}
	//			if (thingyToFind4[store] == null)
	//			{
	//				Debug.Log("CancelInvoke");
	//				CancelInvoke("generateBullateOfEnemy4");
	//				Invoke("generateBullateOfEnemy4", 0.1f);
	//			}

	//	}


	//	if (Player_Controller.manageani == 1)
	//	{
	//		CancelInvoke("generateBullateOfEnemy4");

	//	}
	//}
	//void generateBullateOfEnemy3()
	//{
	//	Debug.Log("generateBullateOfEnemy3Call");
	//	if (Player_Controller.manageani == 0)
	//	{

	//	    	int store = Random.Range(0, thingyToFind.Length - 1);

	//			if (thingyToFind[store] != null)
	//			{
	//				Instantiate(enemy3bullate, thingyToFind[store].transform.position, Quaternion.identity);
	//				Invoke("generateBullateOfEnemy3", 1f);
	//			}
	//			if (thingyToFind[store] == null)
	//			{
	//				CancelInvoke("generateBullateOfEnemy3");
	//				Invoke("generateBullateOfEnemy3", 0.1f);
	//			}
			
	//	}


	//	if (Player_Controller.manageani == 1)
	//	{
	//		CancelInvoke("generateBullateOfEnemy3");
			
	//	}
	//}


	void Update () 	
	{

		//beginMove Move from Spawn position into Maps

		if (beginMove) {
			Vector3 endPosition = new Vector3 (waypoints [currentWaypoint + 1].transform.position.x,
				                     waypoints [currentWaypoint + 1].transform.position.y, 0);

			Vector3 lastposition = new Vector3(waypoints[waypoints.Length-1].transform.position.x,
									 waypoints[waypoints.Length-1].transform.position.y, 0);

			gameObject.transform.position = Vector3.MoveTowards (gameObject.transform.position, endPosition, speed * Time.deltaTime);
		 
			if (gameObject.transform.position.Equals (endPosition)) {

				if (currentWaypoint < waypoints.Length - 2)
                {
					currentWaypoint++;
					
					
				}
		    	else 
				{
					
					if (loop)

                        currentWaypoint = 0;
					

					else
                    {
                        if (lastSpawnChicken)
                        {
							checkBullateGenerate = true;
							lastSpawnChicken = true;
							
							//GameObject.Find("ChickenHouse").GetComponent<Animator>().SetTrigger("move");
						}
						beginMove = false;
                    }
                    if (huntAlone)
					{
						beginHuntAlone = true;
						
					}
                  
				}

				
			}

			//thingyToFind1 = GameObject.FindGameObjectsWithTag("EnemyTag1");
			//thingyToFind2 = GameObject.FindGameObjectsWithTag("EnemyTag2");
			//thingyToFind = GameObject.FindGameObjectsWithTag("EnemyTag3");
			//thingyToFind4 = GameObject.FindGameObjectsWithTag("EnemyTag4");
			//thingyToFind5 = GameObject.FindGameObjectsWithTag("EnemyTag5");
			//thingyToFind6 = GameObject.FindGameObjectsWithTag("EnemyTag6");



			//if (!(thingyToFind1.Length == 0))
			//{
			//	Debug.Log("lastenemycalled" + thingyToFind1.Length);

			//	if ((thingyToFind1[thingyToFind1.Length - 1].transform.position.Equals(lastposition)) && manage[0] == 0 && thingyToFind1.Length > 0)
			//	{

			//		Debug.Log("thingyToFindCalled1");
			//		moveallobject();
			//		manage[0] = 1;

			//	}

			//}

			//else if (!(thingyToFind2.Length == 0))
			//{

			//	if ((thingyToFind2[thingyToFind2.Length - 1].transform.position.Equals(lastposition)) && manage[1] == 0 && thingyToFind2.Length > 0)
			//	{
			//		manage[1] = 1;
			//		Debug.Log("thingyToFindCalled2");
			//		moveallobject();

			//	}

			//}

			//else if (!(thingyToFind.Length == 0))
			//{

			//	if ((thingyToFind[thingyToFind.Length - 1].transform.position.Equals(lastposition)) && manage[2] == 0 && thingyToFind.Length > 0)
			//	{
			//		manage[2] = 1;
			//		Debug.Log("thingyToFindCalled3");
			//		moveallobject();

			//	}

			//}

			//else if (!(thingyToFind4.Length == 0))
			//{

			//	if ((thingyToFind4[thingyToFind4.Length - 1].transform.position.Equals(lastposition)) && manage[3] == 0 && thingyToFind4.Length > 0)
			//	{
			//		manage[3] = 1;
			//		Debug.Log("thingyToFindCalled4");
			//		moveallobject();

			//	}

			//}

			//else if (!(thingyToFind5.Length == 0))
			//{
			//	if ((thingyToFind5[thingyToFind5.Length - 1].transform.position.Equals(lastposition)) && manage[4] == 0 && thingyToFind5.Length > 0)
			//	{
			//		manage[4] = 1;
			//		Debug.Log("thingyToFindCalled5");
			//		moveallobject();
			//	}
			//}

			//else if (!(thingyToFind6.Length == 0))

			//{
			//	if ((thingyToFind6[thingyToFind6.Length - 1].transform.position.Equals(lastposition)) && manage[5] == 0 && thingyToFind6.Length > 0)
			//	{
			//		manage[5] = 1;
			//		Debug.Log("thingyToFindCalled6");
			//		moveallobject();
			//	}
			//}

		}

		//Check when it reaches the correct grid position, then chicken start animation,move


		//beginHunt Start hunting the player
		if (beginHunt)
		{
			if (transform.position.y > PlayerY) {
				transform.Translate ((vx) * Time.deltaTime, (vy - 19.8f * elapse_time) * Time.deltaTime * HeSovy, 0);
				transform.position = new Vector3 (transform.position.x, transform.position.y, -1);
				elapse_time += Time.deltaTime * HeSoelapse_time;
			} else {
				beginHunt = false;
				checkOutHunt = true;
			}
		}

		//Check when move correct position on Map,then Put them on ChickenHouse
		if (checkOutHunt) {
			Vector3 endPosition = new Vector3 (waypoints [waypoints.Length - 1].transform.position.x,
				waypoints [waypoints.Length - 1].transform.position.y, 1);

			gameObject.transform.position = Vector3.MoveTowards (gameObject.transform.position, endPosition, speed * Time.deltaTime);

			
			
		}

		
	}

	public void moveparabol(Vector3 start, Vector3 end, float t)
	{
		PlayerY = end.y;
		float x = (end.x - start.x);
		float y = (end.y - start.y);
		vx = x / t;
		vy = (y + 0.5f * 19.8f * t * t) / t;
//		Debug.Log (vx + " " + vy);
	}

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("BullateTag"))
        {
            //if (gameObject.CompareTag("EnemyTag") && !(gameObject==null))
            {
				Heath--;

				if (Heath==0)
                {

					Vector3 storepos = new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y + 0.5f,
						other.gameObject.transform.position.z);

					if (gameObject.CompareTag("Stone"))
					{
						GameObject zombiebloodnew = Instantiate(stoneblastpart, storepos,
							   other.gameObject.transform.rotation);

						SoundManagerScript.playsound("BombSound");
					}
					else
					{
						
						GameObject zombiebloodnew = Instantiate(blastpart, storepos,
							   other.gameObject.transform.rotation);
						blastpart.transform.localScale = new Vector3(1f, 1f, 1f);
						Destroy(zombiebloodnew, 0.5f);
						SoundManagerScript.playsound("EnemyDieSound");
					}

					if(countDieEnemy%2==0)
					{
						GameObject coinruntime = Instantiate(coingenerate, storepos,
						   other.gameObject.transform.rotation);
					}


					

					if (Player_Controller.powerGenerate_manage<12)
					{
						if (ChickenControl.Instance.howmanyPower==3)

						{
							if (countDieEnemy == 2)
							{
								GameObject generatepre = Instantiate(powerGenerate_prefabs, storepos,
								 other.gameObject.transform.rotation);
								SoundManagerScript.playsound("PowerGenerateSound");
							}
							if (countDieEnemy == 10)
							{
								GameObject generatepre = Instantiate(powerGenerate_prefabs, storepos,
								 other.gameObject.transform.rotation);
								SoundManagerScript.playsound("PowerGenerateSound");
							}
							if (countDieEnemy == 20)
							{
								GameObject generatepre = Instantiate(powerGenerate_prefabs, storepos,
								 other.gameObject.transform.rotation);
								SoundManagerScript.playsound("PowerGenerateSound");
							}
						}

						else if (ChickenControl.Instance.howmanyPower ==2)

						{
							if (countDieEnemy == 4)
							{
								GameObject generatepre = Instantiate(powerGenerate_prefabs, storepos,
								 other.gameObject.transform.rotation);
								SoundManagerScript.playsound("PowerGenerateSound");
							}

							if (countDieEnemy == 12)
							{
								GameObject generatepre = Instantiate(powerGenerate_prefabs, storepos,
								 other.gameObject.transform.rotation);
								SoundManagerScript.playsound("PowerGenerateSound");
							}
						}

						else if (ChickenControl.Instance.howmanyPower == 1)
						{
							if (countDieEnemy == 4)
							{
								GameObject generatepre = Instantiate(powerGenerate_prefabs, storepos,
								 other.gameObject.transform.rotation);
								SoundManagerScript.playsound("PowerGenerateSound");
							}
						}

					}

					
					countDieEnemy++;
					Destroy(gameObject);
					//gameObject.GetComponent<MoveEnemy>().enabled = false;

					
					
				}
               
                Debug.Log("countDieEnemyvalue" + countDieEnemy);
				Debug.Log("Helth" + Heath);
			}
        }

		if (other.CompareTag("EnemyWallTag"))
		{
			countDieEnemy++;
			Destroy(gameObject);
			gameObject.GetComponent<MoveEnemy>().enabled = false;
		}


    }
}
