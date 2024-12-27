using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public manager dmanager;
    void OnTriggerEnter()
    {
        dmanager.CompleteLevel();
    }
}
