using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed;
    public float jump;

    private float Move;

    public Rigidbody2D rb;

   public bool isJumping;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

        // Update is called once per frame
    void Update()
    {
        
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && isJumping == false)
            rb.AddForce(new Vector2(rb.velocity.x, jump));




private void onCollisionEnter2D(Collision2D other)
        }
     if(other.gameObject.CompareTag("Floor"))

        isJumping= flase;
    }
}

private void onCollisionExit2D(Collision2D other)

if(other.gameObject.CompareTag("Floor"))

    isJumping =true;

