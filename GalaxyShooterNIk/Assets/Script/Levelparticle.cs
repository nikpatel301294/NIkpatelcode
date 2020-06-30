using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelparticle : MonoBehaviour
{
    public GameObject storepart1;
    public Transform storepos1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Levelparticle");
        GameObject coinruntime = Instantiate(storepart1, storepos1.position,
                           Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
