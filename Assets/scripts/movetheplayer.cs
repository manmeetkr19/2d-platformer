using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetheplayer : MonoBehaviour
{
    public float runspeed, jumpforce;
    
    private float moveinput,jumpheight=1.5f;
    private Rigidbody2D mybody;
    private bool facingright = true;
    private bool grounded;
    public Vector3 range;
    public Transform groundcheck;
    public LayerMask groundlayer;
    
    void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
        
    }

    
    void FixedUpdate()
    {
        Movement();
        Checkcollisonforjump();
    }
    void Movement()
    {
        moveinput = Input.GetAxisRaw("Horizontal") * runspeed;
        mybody.velocity = new Vector2(moveinput, mybody.velocity.y);

       // if (Input.GetKeyDown("w"))
       // {
       //     if(mybody.velocity.y > 0)
       //     {
        //        mybody.velocity = new Vector2(mybody.velocity.x, mybody.velocity.y * jumpheight);
        //    }
      //  }
        if (moveinput > 0 && !facingright || moveinput < 0 && facingright)
            Flip();
    }
    void Checkcollisonforjump()
    {
        Collider2D bottomhit = Physics2D.OverlapBox(groundcheck.position, range, 0, groundlayer);
        if(bottomhit!= null)
        {
            if(bottomhit.gameObject.tag=="Ground"&& Input.GetKey("w"))
            {
                mybody.velocity = new Vector2(mybody.velocity.x, jumpforce);
            }
        }
    }



    void Flip()
    {
        facingright = !facingright;
        Vector2 transformScale = transform.localScale;
        transformScale.x *= -1;
        transform.localScale = transformScale;
    }
}
