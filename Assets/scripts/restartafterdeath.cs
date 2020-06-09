using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartafterdeath : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DeathFallFunction();
    }
    void DeathFallFunction()
    {
        if (gameObject.transform.position.y <=-10)
        {
            SceneManager.LoadScene(Application.loadedLevel);
        }
    }
}
