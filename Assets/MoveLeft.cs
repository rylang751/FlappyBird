using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        // Move pipes left
        transform.Translate(Vector2.left * Time.deltaTime * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
