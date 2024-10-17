using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float baseSpeed = 1.5f;
    public float jumpPower = 5f;

    public float sprintSpeed = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
    
        Debug.Log("Player is ready to explore!");
        transform.position = new Vector3 (0,0,0);
        
    }

    // Update is called once per frame
    void Update()
    {
        bool spacePressed = Input.GetKeyDown(KeyCode.Space);
          //change to jumping
       if (spacePressed)
        {
            Rigidbody myRigidBody = GetComponent<Rigidbody>();
            myRigidBody.AddForce(new Vector3(0,10,0), ForceMode.Impulse);
            
            //transform.position = transform.position + new Vector3 (0,10,0) * jumpPower *Time.deltaTime;
            //Debug.Log ("space pressed");
            
        }
        
        bool downPressed = Input.GetKey(KeyCode.DownArrow);
        if (downPressed)
        {
            transform.position = transform.position + new Vector3 (0,0,-3) * baseSpeed * Time.deltaTime;
        }
        
        bool rightPressed = Input.GetKey(KeyCode.RightArrow);
        if (rightPressed)
        {
            transform.position = transform.position + new Vector3 (3,0,0) * baseSpeed * Time.deltaTime;
        }
        
        bool leftPressed = Input.GetKey(KeyCode.LeftArrow);
        if (leftPressed)
        {
            transform.position = transform.position + new Vector3 (-3,0,0) * baseSpeed * Time.deltaTime;
        }

        bool upPressed = Input.GetKey(KeyCode.UpArrow);
        if (upPressed)
        {
            transform.position = transform.position + new Vector3 (0,0,3) * baseSpeed * Time.deltaTime;
            //Vector3 distance_to_move = new Vector3(0,0,1) * baseSpeed * Time.deltaTime;
            //Debug.Log ("nyooooom");
        }

        bool shiftPressed = Input.GetKeyDown(KeyCode.LeftShift);
        if (shiftPressed)
        {
            //Debug.Log ("sprinting!");
            baseSpeed = baseSpeed * 3; 
            
            //baseSpeed * sprintSpeed * Time.deltaTime; 
        }
        bool shiftReleased = Input.GetKeyUp(KeyCode.LeftShift);
        if (shiftReleased)
        {
            baseSpeed = 1.5f; 
        }

    }
}
