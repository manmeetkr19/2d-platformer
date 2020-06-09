using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyfire : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    public Transform firepoint;
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(bullet, firepoint.position, transform.rotation);
    }
}
