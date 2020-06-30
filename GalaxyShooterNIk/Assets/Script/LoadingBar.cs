using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DentedPixel;
public class LoadingBar : MonoBehaviour
{
    public GameObject bar;
    public int time;

   
    // Start is called before the first frame update
    void Start()
    {
        Animatebar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Animatebar()
    {
        LeanTween.scaleX(bar, 1, time).setOnComplete(call);
    }
    void call()
    {
        //nextlevelcalled
        SceneManager.LoadScene(ButtonTouch.nextSceneIndex);
    }
}
