using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResumeLevelScript : MonoBehaviour
{
    public GameObject [] storenumber;
    public GameObject storepanelresume;
    public int passvalue;

    public static ResumeLevelScript Instance;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;

        for (int i = 0; i < storenumber.Length; i++)
        {
            storenumber[i].SetActive(false);
        }

        storenumber[0].SetActive(true);

        InvokeRepeating("changeNumber",2f,1f);
    }

    void changeNumber()
    {
        passvalue++;
        
        if (passvalue<6)
        {
            SoundManagerScript.playsound("clocksound");

            for (int i = 0; i < storenumber.Length; i++)
            {
                storenumber[i].SetActive(false);
            }

            storenumber[passvalue].SetActive(true);
        }
       
       
    }
    // Update is called once per frame
    void Update()
    {
        if(passvalue==6)
        {
            CancelInvoke("changeNumber");
            //levelfailcalled
            SceneManager.LoadScene("level_failed", LoadSceneMode.Additive);
            passvalue = 7;
        }
    }
}
