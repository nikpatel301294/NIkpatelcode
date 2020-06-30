using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullateDestroy : MonoBehaviour
{
    public float speed = 5;
    public int damage;
    public Vector3 startPosition;
    public Vector3 targetPosition;
  //  public GameObject Prefab_BulletDestroy, Prefab_EnemyDestroy, EF_PlayerDie;

    private float distance;
    private float startTime;

   // private int hit;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        distance = Vector3.Distance(startPosition, targetPosition);
    }

    // Update is called once per frame
    void Update()
    {
        //
        float timeInterval = Time.time - startTime;
        gameObject.transform.position = Vector3.Lerp(startPosition, targetPosition, timeInterval * speed / distance);

    }
	void OnTriggerEnter2D(Collider2D other)
	{
      
        if (other.CompareTag("EnemyWallTag"))
        {
          
            Destroy(gameObject);
           
        }
        if (other.CompareTag("planeProtectCircle"))
        {
            Debug.Log("BullateDie5555");
            Destroy(gameObject);

        }
    }
}
