using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dissapearcactus : MonoBehaviour
{
    public GameObject cactus;
    public GameObject reference;
    private Vector3 pos;
    void Start()
    {
        pos = new Vector3(117, -12, 0); 
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collide)
    {
       
       // if (collide.gameObject.tag =="player")
       // {

         Instantiate(cactus, new Vector3(117,-12,0) ,transform.rotation) ;
       // }
        
    }
   
}
