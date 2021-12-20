using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float Xspeed,Yspeed;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.velocity = new Vector2(-Xspeed, rb2d.velocity.y);
        }          
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.velocity = new Vector2(Xspeed, rb2d.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(new Vector2(0,Yspeed),ForceMode2D.Impulse);
            
        }
    }
}
