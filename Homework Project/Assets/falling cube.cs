using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingcube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-20f,15f,0f);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void OnCollisionEnter (Collision collision)
    {
        transform.position = new Vector3(-20f,15f,0f);
        //Debug.Log("Hiiiii");
    }

}
