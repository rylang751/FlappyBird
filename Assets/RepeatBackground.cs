using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{

    void Start ()
    void
    {
        startPos = transform.position;
        repeatWidth = startPos.x - 3.5f;
    }

    // Update is called once per frame
    void Update()
    
        if(transform.position.x < repeatWidth)
        {
            transform.position = startPos;
        }
}

