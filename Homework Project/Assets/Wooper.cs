using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wooper : MonoBehaviour
{ 
public float baseSpeed = 1.0f;
public float movementDirection;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Wooper is ready to explore!");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + movementDirection * baseSpeed * Time.deltaTime;

    }
}
