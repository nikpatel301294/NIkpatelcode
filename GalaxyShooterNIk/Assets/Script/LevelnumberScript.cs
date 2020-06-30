using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelnumberScript : MonoBehaviour
{
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        int store = (SceneManager.GetActiveScene().buildIndex-1);
        text.text = store.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
