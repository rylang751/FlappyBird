using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Move pipes left
        transfrom.Translate(Vector2.left * TimedeltaTime * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
