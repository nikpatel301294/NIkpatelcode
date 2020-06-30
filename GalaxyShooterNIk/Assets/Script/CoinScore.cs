using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScore : MonoBehaviour
{
    public static int coinCount;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        coinCount = PlayerPrefs.GetInt("CoinScoreStore");
        //PlayerPrefs.SetInt("CoinScoreStore", PlayerPrefs.GetInt("CoinScoreStore"));
    }

    // Update is called once per frame
    void Update()
    {
        text.text = coinCount.ToString();
        PlayerPrefs.SetInt("CoinScoreStore",coinCount);
        Debug.Log("CoinScoreStoreUpadate" + PlayerPrefs.GetInt("CoinScoreStore"));
    }
}
