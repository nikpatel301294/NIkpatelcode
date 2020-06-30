using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinScript : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreLayerCollision(8,9);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Player1") || other.CompareTag("Player2"))
        {
            // Debug.Log("BullateDie");
            SoundManagerScript.playsound("CoinSound");
            Destroy(gameObject);
            CoinScore.coinCount= CoinScore.coinCount+20;
            PlayerPrefs.SetInt("CoinScoreStore", CoinScore.coinCount);

        }
        if (other.CompareTag("EnemyWallTag"))
        {
            Destroy(gameObject);
        }
    }
}
