using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour
{
    public int health = 100;
   public GameObject death;
    public void takedamage(int damage)
    {
        health -= damage;
        if(health<=0)
        {
            diee();
        }
        void diee()
        {
          //  Instantiate(deatheffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
  
}
