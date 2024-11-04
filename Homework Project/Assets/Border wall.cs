using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borderwall : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit (Collider collision)
    {
        GameObject collisionGameObject = collision.gameObject;

        if(collision.gameObject.name == "Player")
        {
            Debug.Log ("Can't go this way... seem's you'll have to find another way around.");
            //Transform.position = new Vector3(-5f,-4f,-1f);
        }
    }

}
