using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMove : MonoBehaviour
{
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("BgMoveCalled");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Offset = new Vector2(0, Time.time * Speed);
        GetComponent<Renderer>().material.mainTextureOffset = Offset;
    }
}
