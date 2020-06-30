using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneGenerate : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform[] storepos;
    public GameObject StonePrefbs;
    public GameObject powerGenerate_prefabs;
    public  int totalGeneratestone;
    public  int countGeneratestone;
    public int storeposStore;
    public static int stoneWave;
    void Start()
    {
        if (stoneWave==0)
        {
            InvokeRepeating("Generate_StonePos1", 2f, 2f);
        }
        
    }
    void Generate_StonePos1()
    {
        if (countGeneratestone < totalGeneratestone)
        {
            if(storeposStore<3)
            {
                Instantiate(StonePrefbs, storepos[storeposStore].transform.position, Quaternion.identity);
            }
            else
            {
                storeposStore = 0;
                GameObject generatepre = Instantiate(powerGenerate_prefabs, storepos[storeposStore].transform.position,
                         Quaternion.identity);
            }

            storeposStore++;
            countGeneratestone++;
        }
        
    }
   
    // Update is called once per frame
    void Update()
    {
       
    }
}
