using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour
{
    public float coin=0; 
    public GameObject coinobj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.name == "coin")
        {
            coin++;
            Debug.Log(coin);
            Destroy(coinobj);

        }
        //do stuff

    }

}
