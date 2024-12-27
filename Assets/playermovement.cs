using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rigb;
    public float forwardForce = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("hello students");
        //rigb.useGravity = false;

    }

    // Update is called once per frame
     void FixedUpdate()
    {
        rigb.AddForce(0, 0, forwardForce * Time.deltaTime);  //forward force makes the object move forward
        
        if (Input.GetKey("d"))
        {
            rigb.AddForce(500 * Time.deltaTime, 0, 0);       // when d is clicked, force 500 is added towards the x side of the object (goes right)
        }
        if (Input.GetKey("a"))
        {
            rigb.AddForce(-500 * Time.deltaTime, 0, 0);      // when d is clicked, force -500 is added towards the x side of the object (goes left)
        }
        if (rigb.position.y < -1f)
        {
            FindObjectOfType<manager>().EndGame();     // calls the endgame code in the manger file and ends the game when the player falls of the ground
        }
    }
}
