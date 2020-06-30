using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyScript : MonoBehaviour
{
    public GameObject[] Ship;
    public RectTransform middelpoint;
    public RectTransform leftpoint;
    public RectTransform rightpoint;
    public GameObject panelStore;
    public GameObject leftbutton;
    public GameObject rightbutton;
    
    public int[]left;
    public int[]right;

    static int leftmanage;
    static int rightmanage;

    static bool active;

    public static BuyScript Instance;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("USeitbuttonplane1", 1);

        //PlayerPrefs.SetInt("USeitbuttonplane2", 1);
        //PlayerPrefs.SetInt("USeitbuttonplane3", 1);
        //PlayerPrefs.SetInt("USeitbuttonplane4", 1);
        //PlayerPrefs.SetInt("USeitbuttonplane5", 1);

        if (PlayerPrefs.GetInt("USeitbuttonplane1") == 1)
        {
            Ship[0].transform.GetChild(6).gameObject.SetActive(true);
            Ship[0].transform.GetChild(7).gameObject.SetActive(false);
            Ship[0].transform.GetChild(2).gameObject.SetActive(false);
            Ship[0].transform.GetChild(5).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("USeitbuttonplane2") == 1)
        {
            Ship[1].transform.GetChild(4).gameObject.SetActive(true);
            Ship[1].transform.GetChild(5).gameObject.SetActive(false);
            Ship[1].transform.GetChild(2).gameObject.SetActive(false);
            Ship[1].transform.GetChild(3).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("USeitbuttonplane3") == 1)
        {
            Ship[2].transform.GetChild(4).gameObject.SetActive(true);
            Ship[2].transform.GetChild(5).gameObject.SetActive(false);
            Ship[2].transform.GetChild(2).gameObject.SetActive(false);
            Ship[2].transform.GetChild(3).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("USeitbuttonplane4") == 1)
        {
            Ship[3].transform.GetChild(4).gameObject.SetActive(true);
            Ship[3].transform.GetChild(5).gameObject.SetActive(false);
            Ship[3].transform.GetChild(2).gameObject.SetActive(false);
            Ship[3].transform.GetChild(3).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("USeitbuttonplane5") == 1)
        {
            Ship[4].transform.GetChild(4).gameObject.SetActive(true);
            Ship[4].transform.GetChild(5).gameObject.SetActive(false);
            Ship[4].transform.GetChild(2).gameObject.SetActive(false);
            Ship[4].transform.GetChild(3).gameObject.SetActive(false);
        }
        Instance = this;
        Debug.Log("buyscriptcalled");
       // Ship[0].GetComponent<RectTransform>().anchoredPosition = leftpoint.GetComponent<RectTransform>().anchoredPosition;
        Ship[1].GetComponent<RectTransform>().anchoredPosition = rightpoint.GetComponent<RectTransform>().anchoredPosition;
        Ship[2].GetComponent<RectTransform>().anchoredPosition = rightpoint.GetComponent<RectTransform>().anchoredPosition;
        Ship[3].GetComponent<RectTransform>().anchoredPosition = rightpoint.GetComponent<RectTransform>().anchoredPosition;
        Ship[4].GetComponent<RectTransform>().anchoredPosition = rightpoint.GetComponent<RectTransform>().anchoredPosition;

    }
    void activefalse()
    {
        active = false;
    }
    // Update is called once per frame
    void Update()
    {
       
        if (Ship[0].transform.position.x.Equals(middelpoint.position.x))
        {
            leftbutton.SetActive(false);
        }
        else
        {
            leftbutton.SetActive(true);
        }

        if (Ship[4].transform.position.x.Equals(middelpoint.position.x))
        {
            rightbutton.SetActive(false);
        }
        else
        {
            rightbutton.SetActive(true);
        }

       
        if(leftmanage==0)
        {
            if (left[1] == 1)
            {
                Debug.Log("left1");
                Ship[1].GetComponent<RectTransform>().anchoredPosition = Vector3.MoveTowards(Ship[1].GetComponent<RectTransform>().anchoredPosition, rightpoint.GetComponent<RectTransform>().anchoredPosition, 700f * Time.deltaTime);
                Ship[0].GetComponent<RectTransform>().anchoredPosition = Vector3.MoveTowards(Ship[0].GetComponent<RectTransform>().anchoredPosition, middelpoint.GetComponent<RectTransform>().anchoredPosition, 700f * Time.deltaTime);
            }
            else if (left[2] == 1)
            {
                Debug.Log("left2");
                Ship[2].GetComponent<RectTransform>().anchoredPosition = Vector3.MoveTowards(Ship[2].GetComponent<RectTransform>().anchoredPosition, rightpoint.GetComponent<RectTransform>().anchoredPosition, 700f * Time.deltaTime);
                Ship[1].GetComponent<RectTransform>().anchoredPosition = Vector3.MoveTowards(Ship[1].GetComponent<RectTransform>().anchoredPosition, middelpoint.GetComponent<RectTransform>().anchoredPosition, 700f * Time.deltaTime);
            }
            else if (left[3] == 1)
            {
                Debug.Log("left3");
                Ship[3].GetComponent<RectTransform>().anchoredPosition = Vector3.MoveTowards(Ship[3].GetComponent<RectTransform>().anchoredPosition, rightpoint.GetComponent<RectTransform>().anchoredPosition, 700f * Time.deltaTime);
                Ship[2].GetComponent<RectTransform>().anchoredPosition = Vector3.MoveTowards(Ship[2].GetComponent<RectTransform>().anchoredPosition, middelpoint.GetComponent<RectTransform>().anchoredPosition, 700f * Time.deltaTime);
            }
            else if (left[4] == 1)
            {
                Debug.Log("left4");
                Ship[4].GetComponent<RectTransform>().anchoredPosition = Vector3.MoveTowards(Ship[4].GetComponent<RectTransform>().anchoredPosition, rightpoint.GetComponent<RectTransform>().anchoredPosition, 700f * Time.deltaTime);
                Ship[3].GetComponent<RectTransform>().anchoredPosition = Vector3.MoveTowards(Ship[3].GetComponent<RectTransform>().anchoredPosition, middelpoint.GetComponent<RectTransform>().anchoredPosition, 700f * Time.deltaTime);
            }
        }
        if (rightmanage == 0)
        {
            if (right[0] == 1)
            {
                Debug.Log("right0");
                Ship[0].GetComponent<RectTransform>().anchoredPosition = Vector3.MoveTowards(Ship[0].GetComponent<RectTransform>().anchoredPosition, leftpoint.GetComponent<RectTransform>().anchoredPosition, 700f * Time.deltaTime);
                Ship[1].GetComponent<RectTransform>().anchoredPosition = Vector3.MoveTowards(Ship[1].GetComponent<RectTransform>().anchoredPosition, middelpoint.GetComponent<RectTransform>().anchoredPosition, 700f * Time.deltaTime);

            }
            else if (right[1] == 1)
            {
                Debug.Log("right1");
                Ship[1].GetComponent<RectTransform>().anchoredPosition = Vector3.MoveTowards(Ship[1].GetComponent<RectTransform>().anchoredPosition, leftpoint.GetComponent<RectTransform>().anchoredPosition, 700f * Time.deltaTime);
                Ship[2].GetComponent<RectTransform>().anchoredPosition = Vector3.MoveTowards(Ship[2].GetComponent<RectTransform>().anchoredPosition, middelpoint.GetComponent<RectTransform>().anchoredPosition, 700f * Time.deltaTime);

            }
            else if (right[2] == 1)
            {
                Debug.Log("right2");
                Ship[2].GetComponent<RectTransform>().anchoredPosition = Vector3.MoveTowards(Ship[2].GetComponent<RectTransform>().anchoredPosition, leftpoint.GetComponent<RectTransform>().anchoredPosition, 700f * Time.deltaTime);
                Ship[3].GetComponent<RectTransform>().anchoredPosition = Vector3.MoveTowards(Ship[3].GetComponent<RectTransform>().anchoredPosition, middelpoint.GetComponent<RectTransform>().anchoredPosition, 700f * Time.deltaTime);

            }
            else if (right[3] == 1)
            {
                Debug.Log("right3");
                Ship[3].GetComponent<RectTransform>().anchoredPosition = Vector3.MoveTowards(Ship[3].GetComponent<RectTransform>().anchoredPosition, leftpoint.GetComponent<RectTransform>().anchoredPosition, 700f * Time.deltaTime);
                Ship[4].GetComponent<RectTransform>().anchoredPosition = Vector3.MoveTowards(Ship[4].GetComponent<RectTransform>().anchoredPosition, middelpoint.GetComponent<RectTransform>().anchoredPosition, 700f * Time.deltaTime);

            }
        }
       
    }
    public void leftBUttonTouch()
    {
        if (active == false)
        {
            SoundManagerScript.playsound("ButtonTouchSound1");
            rightmanage = 1;
            leftmanage = 0;
            for (int i = 0; i < Ship.Length; i++)
            {
                left[i] = 0;
                right[i] = 0;
            }
            for (int i = 0; i < Ship.Length; i++)
            {
                if (Ship[i].transform.position.x.Equals(middelpoint.position.x))
                {
                    left[i] = 1;
                }
            }

            active = true;

            Invoke("activefalse",1f);
        }
        
    }
    public void rightBUttonTouch()
    {
        if (active == false)
        {
            SoundManagerScript.playsound("ButtonTouchSound1");
            leftmanage = 1;
            rightmanage = 0;
            for (int i = 0; i < Ship.Length; i++)
        {
            left[i] = 0;
            right[i] = 0;
        }

            for (int i = 0; i < Ship.Length; i++)
        {
            if (Ship[i].transform.position.x.Equals(middelpoint.position.x))
            {
                right[i] = 1;
            }
        }

            active = true;

            Invoke("activefalse", 1f);
        }
    }
}
