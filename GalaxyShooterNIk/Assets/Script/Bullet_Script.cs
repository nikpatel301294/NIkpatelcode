using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Script : MonoBehaviour
{
    public float speed = 6f;
    public float deactivate_Timer = 3f;
    public int damage;
    public Vector3 startPosition;
    public Vector3 targetPosition;
    private float distance;
    private float startTime;


    // Start is called before the first frame update
    void Start()
    {
        //Invoke("Destory_bullet", deactivate_Timer);

        startTime = Time.time;
        distance = Vector3.Distance(startPosition, targetPosition);
    }

    // Update is called once per frame
    void Update()
    {
       // Move();


        float timeInterval = Time.time - startTime;
        gameObject.transform.position = Vector3.Lerp(startPosition, targetPosition, timeInterval * speed/ distance);

    }

    void Move()
    {
        Vector3 temp = transform.position;
        temp.y += speed * Time.deltaTime;

        transform.position = temp;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("EnemyTag") || other.CompareTag("EnemyTag1") || other.CompareTag("EnemyTag2") ||
            other.CompareTag("EnemyTag3") || other.CompareTag("EnemyTag4") || other.CompareTag("EnemyTag5")
            || other.CompareTag("EnemyTag6") || other.CompareTag("EnemyTag7") || other.CompareTag("BullateDestroyWall") ||other.CompareTag("Stone"))
        {
            // Debug.Log("BullateDie");
            Destroy(gameObject);

        }
       
    }

}
