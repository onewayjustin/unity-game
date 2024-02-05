using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
public float speed;
public float jump;

private float move;

public Rigidbody2D rb;

    // Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
void Update()
{
    
    move=input.getaxis("Horizont");

    rb.velocity=new Vector2(speed * Move, rb.velocity.y);

    if (input. getButtonDown("jump")) {
        rb.AddfForce(newVector2(rb. velocity. x, jump));

    }

    
}}

