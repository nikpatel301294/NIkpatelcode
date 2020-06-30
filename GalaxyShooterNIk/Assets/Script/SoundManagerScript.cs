 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    // Start is called before the first frame update

    public static AudioClip shotnew;
    static AudioSource source;

    public static AudioClip shotnew1;
    static AudioSource source1;

    public static SoundManagerScript inst;
    // Start is called before the first frame update
    void Start()
    {
        if (inst == null)
        {
            DontDestroyOnLoad(gameObject);

        }

        Debug.Log("Start----------------------");
        source = GetComponent<AudioSource>();
        source1 = GetComponent<AudioSource>();


    }

    
    // Update is called once per frame
    void Update()
    {
       

    }
    public static void playsound(string crul)
    {
        switch (crul)
        {


            case "BombSound":
                shotnew = Resources.Load<AudioClip>("explosion01");
                source.PlayOneShot(shotnew);
               
                break;

            case "EnemyDieSound":
                shotnew = Resources.Load<AudioClip>("EnemyDie2");
                source.PlayOneShot(shotnew);

                break;

            case "PowerGenerateSound":
                shotnew = Resources.Load<AudioClip>("EnemySpawnBomb2");
                source.PlayOneShot(shotnew);

                break;

            case "PowerSound":
                shotnew = Resources.Load<AudioClip>("GetPower1");
                source.PlayOneShot(shotnew);

                break;

            case "CoinSound":
                shotnew = Resources.Load<AudioClip>("GetItemsound");
                source.PlayOneShot(shotnew);

                break;

            case "BossbullateSound":
                shotnew = Resources.Load<AudioClip>("bossgunnew2");
                source.PlayOneShot(shotnew);

                break;
                
            case "BossblastSound":
                shotnew = Resources.Load<AudioClip>("explosion01");
                source.PlayOneShot(shotnew);

                break;

            case "bosstouchsoundcall":
                shotnew = Resources.Load<AudioClip>("Bulletimpactsoundeffect");
                source.PlayOneShot(shotnew);

                break;

            case "PlaneFireSound1":
                shotnew = Resources.Load<AudioClip>("Gun1");
                source.PlayOneShot(shotnew);

                break;

            case "PlaneFireSound2":
                shotnew = Resources.Load<AudioClip>("Gun2");
                source.PlayOneShot(shotnew);

                break;

            case "PlaneFireSound3":
                shotnew = Resources.Load<AudioClip>("laserdound");
                source.PlayOneShot(shotnew);
               
                break;

            case "winsound":
                shotnew = Resources.Load<AudioClip>("Win");
                source.PlayOneShot(shotnew);

                break;

            case "losssound":
                shotnew = Resources.Load<AudioClip>("Lose");
                source.PlayOneShot(shotnew);

                break;

            case "clocksound":
                shotnew = Resources.Load<AudioClip>("CountScore");
                source.PlayOneShot(shotnew);

                break;
                
            case "ButtonTouchSound1":
                shotnew = Resources.Load<AudioClip>("buttonclick");
                source.PlayOneShot(shotnew);

                break;

            case "ButtonTouchSound2":
                shotnew = Resources.Load<AudioClip>("button_touch");
                source.PlayOneShot(shotnew);

                break;
                //case "woodboxbreaksound":

                //    shotnew = Resources.Load<AudioClip>("woodboxbreaknew");
                //    source.PlayOneShot(shotnew);

                //    break;

                //case "levelstart":

                //    shotnew = Resources.Load<AudioClip>("ZombieBreathing");
                //    source.PlayOneShot(shotnew);

                //    break;

                //case "enemypainsound":


                //    shotnew = Resources.Load<AudioClip>("Bulletbodypass");
                //    source.PlayOneShot(shotnew);

                //    break;

                //case "buttontapsound":

                //    shotnew = Resources.Load<AudioClip>("button_tap");
                //    source.PlayOneShot(shotnew);

                //    break;

                //case "buttontouchsound":

                //    shotnew = Resources.Load<AudioClip>("button_touch");
                //    source.PlayOneShot(shotnew);

                //    break;

                //case "levelfailsound":

                //    shotnew = Resources.Load<AudioClip>("levelfailnew");
                //    source.PlayOneShot(shotnew);

                //    break;

                //case "levelcomplatesound":
                //    Debug.Log("levelcomplatesound");

                //    shotnew = Resources.Load<AudioClip>("levelcomnew");
                //    source.PlayOneShot(shotnew);

                //    shotnew1 = Resources.Load<AudioClip>("LevelCompletestar");
                //    source1.PlayOneShot(shotnew1);

                //    break;

                //case "Other":

                //    break;

        }



    }
}
