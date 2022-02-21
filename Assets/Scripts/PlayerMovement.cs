
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // DONE: ground Check
    // DONE: Gravity
    // DONE: Grace period

    private bool IsGrounded
    {
        get
        {
            return coyoteTime > 0;
        }
        set
        {
            coyoteTime =  (value ? 1 : coyoteTime - Time.deltaTime);

            // if (value)
            // {
            //     coyoteTime =(int) (1 / Time.deltaTime);
            // }
            // else
            // {
            //     coyoteTime -=  1;
            // }
        }
    }
[SerializeField]
    private float coyoteTime = 0;
    public LayerMask mask;
    public Transform left, right;
    public float Xspeed,Yspeed;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        rb2d = GetComponent<Rigidbody2D>();
    }

    private float jumpasd;     // Update is called once per frame
    void Update()
    {
        jumpasd -= Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.velocity = new Vector2(-Xspeed, rb2d.velocity.y);
        }          
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.velocity = new Vector2(Xspeed, rb2d.velocity.y);
        }

        IsGrounded = Physics2D.Raycast(left.position, Vector2.down, .3f, mask.value)
                     || Physics2D.Raycast(right.position, Vector2.down, .3f, mask.value);
                 
            
            Debug.Log(IsGrounded);

        if (Input.GetKeyDown(KeyCode.Space)&&IsGrounded)
        {
            rb2d.AddForce(new Vector2(0,Yspeed-rb2d.velocity.y),ForceMode2D.Impulse);
            coyoteTime = 0;
            IsGrounded = false;
            jumpasd = .5f;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (IsGrounded)
            {
                rb2d.gravityScale = 3;
            }
        }
        else
        {
            rb2d.gravityScale = 9;
        }
    }

}
