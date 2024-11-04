using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{

    public float baseSpeed = 1.5f;
    public Material[] material; 
    private Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.name =="Lava")
        {
            Debug.Log("You're on fire!");
            GetComponent<Renderer>().material.color = Color.red;
            baseSpeed = baseSpeed + 5;

            //GetComponent<Renderer> ().material.color = Color.Orange;
        }
    }
private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name =="Cu")
        {
            Debug.Log("AAAAAA");
            GetComponent<Renderer>().material.color = Color.blue;
            transform.localScale += new Vector3(0,-1,0);
            baseSpeed = 1.5f;
        }
        if(collision.gameObject.name =="Cyl")
        {
            Debug.Log("oh wow");
            GetComponent<Renderer>().material.color = Color.yellow;
            transform.localScale += new Vector3(0,1,0);
        }
        if(collision.gameObject.name =="right portal")
        {
            transform.position = new Vector3(0,0,0);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.name == "Sphere")
        {
            Debug.Log("It's just like playing soccer!");
        }
    }

}
