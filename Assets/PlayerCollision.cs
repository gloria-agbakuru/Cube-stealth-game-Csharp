using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public playermovement playermov;        //takes the player objects movement from the playermovement code file
    void OnCollisionEnter(Collision collinfo)  //this means 'when the object collides with anything', the the thing below is what happens when a collision occurs
    {
        //Debug.Log(collinfo.collider.name);   // takes the info of what the object has collided with and spits out the information

        //if (collinfo.collider.name == "obstacle")    // if the  name of the object that hit the player is 'obstacle', perfrom the action below

        if (collinfo.collider.tag == "obstacle")        //// if the tag of the object that hit the player is 'obstacle', perfrom the action below
        {
            playermov.enabled = false;    //when the player hits an object with the tag named obstacle, the player object's movement should stop
            //Debug.Log("we got hit chile");

            FindObjectOfType<manager>().EndGame();       //calls endgame form manger code file ends the game when player gets hit
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
