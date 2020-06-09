using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmove : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
    Vector3 pos;
   //public GameObject impacteffect;
    
    // Start is called before the first frame update
    void Start()
    {
       // pos = transform.position * Input.GetAxis("x");
        rb.velocity = transform.right* speed;
    }

    // Update is called once per frame
    private void Update()
    {
       
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
         die enemy = coll.GetComponent<die>();
         if(enemy!=null)
         {
          enemy.takedamage(damage);
         }
     //   Instantiate(impacteffect, transform.position, transform.rotation);
        
        Destroy(gameObject);
        //  impacteffect.SetActive(false);
        //DestroyImmediate(impacteffect, true);


    }
}
