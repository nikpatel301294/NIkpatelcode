using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone1Script : MonoBehaviour
{
    public int stone1helth;
    public GameObject generateEnemy;

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

            stone1helth--;
            Destroy(other.gameObject);

            if (stone1helth == 0)
            {
                SoundManagerScript.playsound("BossblastSound");
                Destroy(gameObject);
                Vector3 storepos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y,
                    gameObject.transform.position.z);
                GameObject zombiebloodnew = Instantiate(generateEnemy, storepos,
                       gameObject.transform.rotation);
            }


        }
    }
}
