using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class ButtonTouch : MonoBehaviour
{
    public static int nextSceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void loadindscenecalled()
    {
        SoundManagerScript.playsound("ButtonTouchSound1");

        SceneManager.LoadScene("LoadingScene", LoadSceneMode.Single);

        PlayerPrefs.SetInt("WaveIncrement", 0);
        PlayerPrefs.SetInt("manage", 0);
        PlayerPrefs.SetInt("controlplane", 0);
        PlayerPrefs.SetInt("countDieEnemy", 0);
        PlayerPrefs.SetInt("thingyCount", 0);
        PlayerPrefs.SetInt("manageani", 0);
        PlayerPrefs.SetInt("powerGeneratemanage", 1);
        PlayerPrefs.SetInt("bossmanage", 0);
        PlayerPrefs.SetInt("playerHelth", 0);
        PlayerPrefs.SetInt("powerprotectManagestring", 0);
        Time.timeScale = 1;
        nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        PlayerPrefs.SetInt("LevelStore", (nextSceneIndex - 2));
        PlayerPrefs.SetInt("RetraystoreString", ((PlayerPrefs.GetInt("RetraystoreString")) + 1));

        Debug.Log("RetraystoreString" + PlayerPrefs.GetInt("RetraystoreString"));
    }
    public void nextButtonTouch()
    {
        SoundManagerScript.playsound("ButtonTouchSound1");

        PlayerPrefs.SetInt("WaveIncrement", 0);
        PlayerPrefs.SetInt("manage", 0);
        PlayerPrefs.SetInt("controlplane", 0);
        PlayerPrefs.SetInt("countDieEnemy", 0);
        PlayerPrefs.SetInt("thingyCount", 0);
        PlayerPrefs.SetInt("manageani", 0);
        PlayerPrefs.SetInt("powerGeneratemanage", 1);
        PlayerPrefs.SetInt("bossmanage", 0);
        PlayerPrefs.SetInt("playerHelth", 0);
        PlayerPrefs.SetInt("powerprotectManagestring", 0);
        Time.timeScale = 1;
        //nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        //PlayerPrefs.SetInt("LevelStore", (nextSceneIndex-2));
        

        //if (nextSceneIndex == 40)
        //{
        //    SceneManager.LoadScene(0);
        //    PlayerPrefs.SetInt("LevelStore", 1);
        //}

        //else
        //{

        //    SceneManager.LoadScene(nextSceneIndex);
        //}
    }
    void resetvalue()
    {
        SoundManagerScript.playsound("ButtonTouchSound1");

        PlayerPrefs.SetInt("WaveIncrement", 0);
        PlayerPrefs.SetInt("manage", 0);
        PlayerPrefs.SetInt("controlplane", 0);
        PlayerPrefs.SetInt("countDieEnemy", 0);
        PlayerPrefs.SetInt("thingyCount", 0);
        PlayerPrefs.SetInt("manageani", 0);
        PlayerPrefs.SetInt("powerGeneratemanage", 1);
        PlayerPrefs.SetInt("bossmanage", 0);
        PlayerPrefs.SetInt("playerHelth", 0);
        PlayerPrefs.SetInt("powerprotectManagestring", 0);
    }
    public void retrayButtonTouch()
    {
        SoundManagerScript.playsound("ButtonTouchSound1");

        Time.timeScale = 1; 
        SceneManager.LoadScene(PlayerPrefs.GetInt("RetraystoreString"));
       // PlayerPrefs.SetInt("WaveIncrement", 0);
        PlayerPrefs.SetInt("manage", 0);
        PlayerPrefs.SetInt("controlplane", 0);
        PlayerPrefs.SetInt("countDieEnemy", 0);
        PlayerPrefs.SetInt("thingyCount", 0);
        PlayerPrefs.SetInt("manageani", 0);
        PlayerPrefs.SetInt("powerGeneratemanage", 1);
        PlayerPrefs.SetInt("bossmanage", 0);
        PlayerPrefs.SetInt("playerHelth", 0);
        PlayerPrefs.SetInt("powerprotectManagestring", 0);
    }
    public void playButton()
    {
        SoundManagerScript.playsound("ButtonTouchSound1");
        SceneManager.LoadScene("LevelSceneFinal", LoadSceneMode.Single);
    }
    public void yesbutton()
    {
        SoundManagerScript.playsound("ButtonTouchSound1");
        SceneManager.LoadScene("LevelSceneFinal", LoadSceneMode.Single);
        Time.timeScale = 1;
    }
    public void exitpoupcall()
    {
        SoundManagerScript.playsound("ButtonTouchSound1");
        Time.timeScale = 0;
        SceneManager.LoadScene("Exitpopup", LoadSceneMode.Additive);
    }
    public void levelButtonTouch()
    {
        SoundManagerScript.playsound("ButtonTouchSound1");
        Time.timeScale = 1;
        SceneManager.LoadScene("LevelSceneFinal", LoadSceneMode.Single);
        PlayerPrefs.SetInt("manage", 0);
        PlayerPrefs.SetInt("controlplane", 0);
        PlayerPrefs.SetInt("countDieEnemy", 0);
        PlayerPrefs.SetInt("thingyCount", 0);
        PlayerPrefs.SetInt("manageani", 0);
        PlayerPrefs.SetInt("powerGeneratemanage", 1);
        PlayerPrefs.SetInt("bossmanage", 0);
        PlayerPrefs.SetInt("playerHelth", 0);
        PlayerPrefs.SetInt("powerprotectManagestring", 0);
    }


    public void plane1cointouch()
    {
        SoundManagerScript.playsound("ButtonTouchSound1");
        if (PlayerPrefs.GetInt("CoinScoreStore")>1000)
        {
           
            PlayerPrefs.SetInt("CoinScoreStore", (PlayerPrefs.GetInt("CoinScoreStore") - 1000));
            PlayerPrefs.SetInt("USeitbuttonplane1", 1);
            Debug.Log("Coin"+ PlayerPrefs.GetInt("CoinScoreStore"));
            
            BuyScript.Instance.Ship[0].transform.GetChild(6).gameObject.SetActive(true);
            BuyScript.Instance.Ship[0].transform.GetChild(7).gameObject.SetActive(false);
            BuyScript.Instance.Ship[0].transform.GetChild(2).gameObject.SetActive(false);
            BuyScript.Instance.Ship[0].transform.GetChild(5).gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("Not enughe Coin");
            BuyScript.Instance.panelStore.SetActive(true);
        }
        
    }
    public void plane2cointouch()
    {
        SoundManagerScript.playsound("ButtonTouchSound1");

        if (PlayerPrefs.GetInt("CoinScoreStore") > 2000)
        {
            //CoinScore.coinCount = PlayerPrefs.GetInt("CoinScoreStore") - 2000;
            PlayerPrefs.SetInt("CoinScoreStore", (PlayerPrefs.GetInt("CoinScoreStore") - 2000));
            Debug.Log("Coin" + PlayerPrefs.GetInt("CoinScoreStore"));
            PlayerPrefs.SetInt("USeitbuttonplane2", 1);
            BuyScript.Instance.Ship[1].transform.GetChild(4).gameObject.SetActive(true);
            BuyScript.Instance.Ship[1].transform.GetChild(5).gameObject.SetActive(false);
            BuyScript.Instance.Ship[1].transform.GetChild(2).gameObject.SetActive(false);
            BuyScript.Instance.Ship[1].transform.GetChild(3).gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("Not enughe Coin");
            BuyScript.Instance.panelStore.SetActive(true);
        }
    }
    public void plane3cointouch()
    {
        SoundManagerScript.playsound("ButtonTouchSound1");
        if (PlayerPrefs.GetInt("CoinScoreStore") > 5000)
        {
            //CoinScore.coinCount = PlayerPrefs.GetInt("CoinScoreStore") - 5000;
            PlayerPrefs.SetInt("CoinScoreStore", (PlayerPrefs.GetInt("CoinScoreStore") - 5000));
            Debug.Log("Coin" + PlayerPrefs.GetInt("CoinScoreStore"));
            PlayerPrefs.SetInt("USeitbuttonplane3", 1);
            BuyScript.Instance.Ship[2].transform.GetChild(4).gameObject.SetActive(true);
            BuyScript.Instance.Ship[2].transform.GetChild(5).gameObject.SetActive(false);
            BuyScript.Instance.Ship[2].transform.GetChild(2).gameObject.SetActive(false);
            BuyScript.Instance.Ship[2].transform.GetChild(3).gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("Not enughe Coin");
            BuyScript.Instance.panelStore.SetActive(true);
        }
    }
    public void plane4cointouch()
    {
        SoundManagerScript.playsound("ButtonTouchSound1");
        if (PlayerPrefs.GetInt("CoinScoreStore") > 7000)
        {
            //CoinScore.coinCount = PlayerPrefs.GetInt("CoinScoreStore") - 7000;
            PlayerPrefs.SetInt("CoinScoreStore", (PlayerPrefs.GetInt("CoinScoreStore") - 7000));
            Debug.Log("Coin" + PlayerPrefs.GetInt("CoinScoreStore"));
            PlayerPrefs.SetInt("USeitbuttonplane4", 1);
            BuyScript.Instance.Ship[3].transform.GetChild(4).gameObject.SetActive(true);
            BuyScript.Instance.Ship[3].transform.GetChild(5).gameObject.SetActive(false);
            BuyScript.Instance.Ship[3].transform.GetChild(2).gameObject.SetActive(false);
            BuyScript.Instance.Ship[3].transform.GetChild(3).gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("Not enughe Coin");
            BuyScript.Instance.panelStore.SetActive(true);
        }
    }
    public void plane5cointouch()
    {
        SoundManagerScript.playsound("ButtonTouchSound1");
        if (PlayerPrefs.GetInt("CoinScoreStore") > 10000)
        {
            //CoinScore.coinCount = PlayerPrefs.GetInt("CoinScoreStore") - 10000;
            PlayerPrefs.SetInt("CoinScoreStore", (PlayerPrefs.GetInt("CoinScoreStore") - 10000));
            Debug.Log("Coin" + PlayerPrefs.GetInt("CoinScoreStore"));
            PlayerPrefs.SetInt("USeitbuttonplane5", 1);
            BuyScript.Instance.Ship[4].transform.GetChild(4).gameObject.SetActive(true);
            BuyScript.Instance.Ship[4].transform.GetChild(5).gameObject.SetActive(false);
            BuyScript.Instance.Ship[4].transform.GetChild(2).gameObject.SetActive(false);
            BuyScript.Instance.Ship[4].transform.GetChild(3).gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("Not enughe Coin");
            BuyScript.Instance.panelStore.SetActive(true);
        }
    }
    public void enoughpanelclose()
    {
        SoundManagerScript.playsound("ButtonTouchSound1");
        BuyScript.Instance.panelStore.SetActive(false);
    }
    public void exitpoupunload()
    {
        SoundManagerScript.playsound("ButtonTouchSound1");
        Time.timeScale = 1;
        SceneManager.UnloadSceneAsync(27);
        //SceneManager.UnloadScene("Exitpopup");
    }
    void passInLevel()
    {
        if (PlayerPrefs.GetInt("LevelbuttonStirng") == 0)
        {
            SceneManager.LoadScene("Level1", LoadSceneMode.Single);
        }
        else if (PlayerPrefs.GetInt("LevelbuttonStirng") == 1)
        {
            SceneManager.LoadScene("Level2", LoadSceneMode.Single);
        }
        else if (PlayerPrefs.GetInt("LevelbuttonStirng") == 2)
        {
            SceneManager.LoadScene("Level3", LoadSceneMode.Single);
        }
        else if (PlayerPrefs.GetInt("LevelbuttonStirng") == 3)
        {
            SceneManager.LoadScene("Level4", LoadSceneMode.Single);
        }
        else if (PlayerPrefs.GetInt("LevelbuttonStirng") == 4)
        {
            SceneManager.LoadScene("Level5", LoadSceneMode.Single);
        }
        else if (PlayerPrefs.GetInt("LevelbuttonStirng") == 5)
        {
            SceneManager.LoadScene("Level6", LoadSceneMode.Single);
        }
        else if (PlayerPrefs.GetInt("LevelbuttonStirng") == 6)
        {
            SceneManager.LoadScene("Level7", LoadSceneMode.Single);
        }
        else if (PlayerPrefs.GetInt("LevelbuttonStirng") == 7)
        {
            SceneManager.LoadScene("Level8", LoadSceneMode.Single);
        }
        else if (PlayerPrefs.GetInt("LevelbuttonStirng") == 8)
        {
            SceneManager.LoadScene("Level9", LoadSceneMode.Single);
        }
        else if (PlayerPrefs.GetInt("LevelbuttonStirng") == 9)
        {
            SceneManager.LoadScene("Level10", LoadSceneMode.Single);
        }
        else if (PlayerPrefs.GetInt("LevelbuttonStirng") == 10)
        {
            SceneManager.LoadScene("Level11", LoadSceneMode.Single);
        }
        else if (PlayerPrefs.GetInt("LevelbuttonStirng") == 11)
        {
            SceneManager.LoadScene("Level12", LoadSceneMode.Single);
        }
        else if (PlayerPrefs.GetInt("LevelbuttonStirng") == 12)
        {
            SceneManager.LoadScene("Level13", LoadSceneMode.Single);
        }
        else if (PlayerPrefs.GetInt("LevelbuttonStirng") == 13)
        {
            SceneManager.LoadScene("Level14", LoadSceneMode.Single);
        }
        else if (PlayerPrefs.GetInt("LevelbuttonStirng") == 14)
        {
            SceneManager.LoadScene("Level15", LoadSceneMode.Single);
        }
        else if (PlayerPrefs.GetInt("LevelbuttonStirng") == 15)
        {
            SceneManager.LoadScene("Level16", LoadSceneMode.Single);
        }
        else if (PlayerPrefs.GetInt("LevelbuttonStirng") == 16)
        {
            SceneManager.LoadScene("Level17", LoadSceneMode.Single);
        }
        else if (PlayerPrefs.GetInt("LevelbuttonStirng") == 17)
        {
            SceneManager.LoadScene("Level18", LoadSceneMode.Single);
        }
        else if (PlayerPrefs.GetInt("LevelbuttonStirng") == 18)
        {
            SceneManager.LoadScene("Level19", LoadSceneMode.Single);
        }
        else if (PlayerPrefs.GetInt("LevelbuttonStirng") == 19)
        {
            SceneManager.LoadScene("Level20", LoadSceneMode.Single);
        }

    }
    public void plane1Useittouch()
    {
        SoundManagerScript.playsound("ButtonTouchSound1");
        PlayerPrefs.SetInt("whichplaneSelectStore", 1);
        passInLevel();
    }
    public void plane2Useittouch()
    {
        SoundManagerScript.playsound("ButtonTouchSound1");
        PlayerPrefs.SetInt("whichplaneSelectStore", 2);
        passInLevel();
    }
    public void plane3Useittouch()
    {
        SoundManagerScript.playsound("ButtonTouchSound1");
        PlayerPrefs.SetInt("whichplaneSelectStore", 3);
        passInLevel();
    }
    public void plane4Useittouch()
    {
        SoundManagerScript.playsound("ButtonTouchSound1");
        PlayerPrefs.SetInt("whichplaneSelectStore", 4);
        passInLevel();
    }
    public void plane5Useittouch()
    {
        SoundManagerScript.playsound("ButtonTouchSound1");
        PlayerPrefs.SetInt("whichplaneSelectStore", 5);
        passInLevel();
    }


    public void videoButtontouch()
    {
        SoundManagerScript.playsound("ButtonTouchSound1");
        Debug.Log("videoButtontouch");
    }
    public void moregamesButtontouch()
    {
        SoundManagerScript.playsound("ButtonTouchSound1");
        Debug.Log("videoButtontouch");
    }
    public void resumepanelclose()
    {
        SoundManagerScript.playsound("ButtonTouchSound1");
        Time.timeScale = 1;
        ResumeLevelScript.Instance.storepanelresume.SetActive(false);
    }
    public void resumecoinbutton()
    {
        SoundManagerScript.playsound("ButtonTouchSound1");

        if (PlayerPrefs.GetInt("CoinScoreStore") > 2500)
        {
           
            CoinScore.coinCount = PlayerPrefs.GetInt("CoinScoreStore") - 2500;
            SceneManager.UnloadSceneAsync(24);
            //Time.timeScale = 1;
            Player_Controller.Instance.PlaneGenerate();
        }
        else
        {
            Time.timeScale = 0;
            
            ResumeLevelScript.Instance.storepanelresume.SetActive(true);
        }
    }
}
