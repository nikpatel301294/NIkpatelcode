using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelbuttonfalse : MonoBehaviour
{
    public GameObject storelevel;
    // Start is called before the first frame update
    void Start()
    {
        int nextSceneI = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("LevelStore", (nextSceneI - 1));

        if (PlayerPrefs.GetInt("LevelbuttonStirng")==19)
        {
            storelevel.SetActive(false);
        }
        if (PlayerPrefs.GetInt("LevelStore") == 20)
        {
            storelevel.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
