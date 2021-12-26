using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb2d.velocity.x<0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }

        if (rb2d.velocity.x>0)
        {
            GetComponent<SpriteRenderer>().flipX = false;

        }
    }
}
