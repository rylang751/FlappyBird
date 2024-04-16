using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{ 
    Rigidbody2D bird;
    
    void Start() {
        bird = GetComponent<Rigidbody2D> () ;
    }

   

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space)) 
         {
        
            bird.AddForce(new Vector2(0,1) * 200) ;
        
        }
    }
}
