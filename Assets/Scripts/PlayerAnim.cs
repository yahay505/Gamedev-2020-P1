using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public Animator playerAnimator;
    public float speed;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Animator speed
        playerAnimator.SetFloat("speed", Mathf.Abs(rb2d.velocity.x));

        if (rb2d.velocity.x<0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (rb2d.velocity.x>0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
    }
}
