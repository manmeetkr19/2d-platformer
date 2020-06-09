using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunshot : MonoBehaviour
{
    public Transform firepoint1;
  //  public Transform firepoint2;
    public GameObject bulletsprite;
    private float moveinput;
    private bool facingright = true;
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            
            
                shoot();
            
           
        }

    }
        void shoot()
        {
           Instantiate(bulletsprite, firepoint1.position , transform.rotation);
        
        }
  
    
}
