using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavapool : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Debug.Log("Hot hot hot!");
        }
    }
    /*private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.name =="Player")
        {
            Debug.Log("You're on fire!");
            gameObject.GetComponent().material.color= Color.Orange;
        }
    }*/

}
