using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Input = UnityEngine.Windows.Input;

public class Wooper : MonoBehaviour
{ 
public float baseSpeed = 0.5f;
public float jumpPower = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Wooper is ready to explore!");
    }

    // Update is called once per frame
    void Update()
    {
        
        //bool UpArrowPressed = Input.GetKeyDown(KeyCode.UpArrow);

         //if (UpArrowPressed)
        {
            Vector3 distance_to_move=new Vector3(0,1,0)*baseSpeed*Time.deltaTime;
    
        }
        //transform.position = transform.position + new Vector3(1,0,0) * Time.deltaTime;

        //bool isJumpPressed = Input.GetKeyDown (KeyCode.Space);
    }
}