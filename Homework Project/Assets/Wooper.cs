using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wooper : MonoBehaviour
{ 
public float baseSpeed = 0.5f;
public float jumpPower = 1.5f;
public 

bool isRightPressed = input.GetKey(KeyCode.W);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Wooper is ready to explore!");
        transform.position = new Vector3(1,1,1);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (isRightPressed)
        {transform.position = transform.position + new Vector3(1,0,0) * Time.deltaTime;}
    }
}
