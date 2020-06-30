using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneEnemy : MonoBehaviour
{
    public int stoneEnemyhelth;
    public static int CountDiestoneEnemy;
    public GameObject blastpart;
    public GameObject coingenerate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("BullateTag"))
        {

            stoneEnemyhelth--;
            Destroy(other.gameObject);

            if (stoneEnemyhelth == 0)
            {
                CountDiestoneEnemy++;
                SoundManagerScript.playsound("EnemyDieSound");
                Destroy(gameObject);
                Vector3 storepos = new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y + 0.5f,
                         other.gameObject.transform.position.z);
                GameObject zombiebloodnew = Instantiate(blastpart, storepos,
                       other.gameObject.transform.rotation);
                GameObject coinruntime = Instantiate(coingenerate, storepos,
                       other.gameObject.transform.rotation);
                Destroy(zombiebloodnew,0.4f);
            }


        }
        if (other.CompareTag("EnemyWallTag"))
        {
            CountDiestoneEnemy++;
            Destroy(gameObject);
           // gameObject.GetComponent<MoveEnemy>().enabled = false;
        }
    }
}
