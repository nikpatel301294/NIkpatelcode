using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossbullateScipt : MonoBehaviour
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
        startTime = Time.time;
        distance = Vector3.Distance(startPosition, targetPosition);
    }

    // Update is called once per frame
    void Update()
    {
        float timeInterval = Time.time - startTime;
        gameObject.transform.position = Vector3.Lerp(startPosition, targetPosition, timeInterval * speed / distance);

    }
    void Move()
    {
        Vector3 temp = transform.position;
        temp.y += speed * Time.deltaTime;

        transform.position = temp;
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
