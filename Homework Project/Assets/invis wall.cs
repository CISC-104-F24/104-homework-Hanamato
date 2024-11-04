using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inviswall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*bool didPlayerPassThrough = OnTriggerEnter;
        if (didPlayerPassThrough)
        {
            Debug.Log ("Watch out! You're too close to the lava!");
        }
        */
    }

    private void OnTriggerEnter (Collider collision)
    {
        GameObject collisionGameObject = collision.gameObject;

        if(collision.gameObject.name == "Player")
        {
            Debug.Log ("Watch out! You're too close to the lava!");
        }
    }

}
