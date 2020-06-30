 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelButtonTouch : MonoBehaviour
{
    public Button[] buttons;
    public GameObject[] imgesstore;
    public static int storestar;
   

    // Start is called before the first frame update
    void Start()
    {

        imgesstore[0].gameObject.SetActive(false);

        //for (int i = 0; i <= 19; i++)
        //{
        //    imgesstore[i].gameObject.SetActive(false);
        //}

        for (int i = 0; i < buttons.Length; i++)
        {
            int closureIndex = i;
            Button btns = buttons[i].GetComponent<Button>();
            buttons[closureIndex].onClick.AddListener(() => TaskOnClick(closureIndex));
            storestar = closureIndex;
        }

        //if(storestar>0)
        {//PlayerPrefs.SetInt("Levelnumberstore", buttonIndex); 
            for (int i = 0; i <= PlayerPrefs.GetInt("LevelStore"); i++)
            {
                imgesstore[i].gameObject.SetActive(false);
            }
        }

        Debug.Log("Levelnumberstoreprefabs" + PlayerPrefs.GetInt("LevelStore"));

    }

    public void TaskOnClick(int buttonIndex)
    {
        SoundManagerScript.playsound("ButtonTouchSound1");
        PlayerPrefs.SetInt("RetraystoreString", (buttonIndex+2));
        PlayerPrefs.SetInt("LevelbuttonStirng", buttonIndex);
        SceneManager.LoadScene("PlaneSelection", LoadSceneMode.Single);

        //PlayerPrefs.SetInt("LevelbuttonIndex", buttonIndex);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
