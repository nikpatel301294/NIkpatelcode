using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneManage : MonoBehaviour
{
    int whichplaneSelect;
    public GameObject[] totolPlaneobject;
    public static PlaneManage instance ;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        whichplaneSelect = PlayerPrefs.GetInt("whichplaneSelectStore");
        falseallPlane();
        totolPlaneobject[whichplaneSelect - 1].SetActive(true);
    }

    public void falseallPlane()
    {
        for(int i=0;i<totolPlaneobject.Length;i++)
        {
            totolPlaneobject[i].SetActive(false);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
