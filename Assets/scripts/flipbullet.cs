using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipbullet : MonoBehaviour
{
    private bool facingright = true;
    private float moveinput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveinput = Input.GetAxisRaw("Horizontal");
        if (moveinput > 0 && !facingright || moveinput < 0 && facingright)
            Flip();
    }
   void Flip()
    {
        facingright = !facingright;
        transform.Rotate(0f, 180f, 0f);
      
    }
}
