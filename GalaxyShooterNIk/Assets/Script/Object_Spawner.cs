using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Spawner : MonoBehaviour
{

    public float min_X = -1.48f, max_X = 1.48f;
    public float min_Y = -5f, max_Y = 5f;

    public GameObject[] astroid_prefeb;
    //public float timer;
    //public float speed;
    public GameObject storepos;
    int prefab_num;

    public float bound_Y = -12;
    public float bound_Y_up = 12;
    public float bound_X_left = 12;
    public float bound_X = -12;


    public Vector3[] positions;
    //Vector3 pos1;
    //Vector3 pos2;
    //Vector3 pos3;
    //Vector3 pos4;

    int index;
    int index_store;

    Vector3 la;
    bool moveobject;
    int newspeed;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("spawner_object", 5f);

    }


    // Update is called once per frame
    void Update()
    {


    }
  

    void spawner_object()
    {

      //  moveobject = true;

        index = Random.Range(index, positions.Length);

        int  indexstore = Random.Range(1, 1);

        Debug.Log("index2222--->>>" + indexstore);


      // if (Random.Range(0, positions.Length) > 0)
       // {

      
         GameObject newone = Instantiate(astroid_prefeb[Random.Range(0, astroid_prefeb.Length)], positions[0], Quaternion.identity);


        if (indexstore == 1)
        {

            newone.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1);
        }

        //if (indexstore == 1)
        //{
        //    //newone.transform.position = new Vector2(-10, 0);

        //     newone.GetComponent<Rigidbody2D>().velocity = new Vector2(-10, 0);
        //}

        //if (indexstore == 2)
        //{
        //    newone.transform.position = new Vector2(0, 10);

        //    newone.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 10);
        //}

        //if (indexstore == 2)
        //{
        //    //newone.transform.position = new Vector2(10, 0);

        //    newone.GetComponent<Rigidbody2D>().velocity = new Vector2(10, 0);
        //}

        Debug.Log("newspeedvelocity------>>>" + astroid_prefeb[0].GetComponent<Rigidbody2D>().velocity);

          
      new_move();


     

    }

  
   
      

    void new_move()
    {

        Invoke("spawner_object", 10f);
    }
        
    }

