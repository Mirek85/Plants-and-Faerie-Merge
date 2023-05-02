using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{ 
    // The speed at which the background moves

    public float speed = 1.0f;
   
    // The direction of movement

    public Vector2 direction = new Vector2(-1.0f, 0.0f); 

    private Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    private void Update()
    {
        float offset = Time.time * speed;
        Vector2 offsetVector = direction * offset;
        rend.material.mainTextureOffset = offsetVector;
    }
}

