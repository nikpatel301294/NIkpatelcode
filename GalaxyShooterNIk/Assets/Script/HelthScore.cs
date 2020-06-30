using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HelthScore : MonoBehaviour
{
    public  static int helthCount=3;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
        text.text = helthCount.ToString();
        PlayerPrefs.SetInt("helthScoreStore", helthCount);
    }
}
