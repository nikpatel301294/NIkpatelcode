using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DebugeClass : MonoBehaviour
{
    // Start is called before the first frame update

    public static Text text;

    void Start()
    {
        text = GetComponent<Text>();
        text.text = "printmessage";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
