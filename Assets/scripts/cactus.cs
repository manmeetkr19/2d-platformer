using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cactus : MonoBehaviour
{
    //public GameObject startpos;
    //public GameObject hero;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            Destroy(collision.gameObject);

            // Debug.Log("entered");
            //  Instantiate(hero, startpos.transform.position, transform.rotation);
            SceneManager.LoadScene(Application.loadedLevel);
        }
    }
}
