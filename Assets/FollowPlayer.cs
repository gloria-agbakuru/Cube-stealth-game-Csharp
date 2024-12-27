using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{                              
    public Transform player;   // this links the transformation of the player to the camera so it would be able to follow it 
    public Vector3 offset = new Vector3(0f, 1f, -5f); 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position);
        transform.position = player.position + offset;
    }
}
