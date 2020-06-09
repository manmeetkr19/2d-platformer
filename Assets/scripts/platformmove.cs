using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformmove : MonoBehaviour
{
    private Vector3 posA; 
    private Vector3 posB;
    private Vector3 nextpos;
    [SerializeField]
    private float speed;
    [SerializeField]
    private Transform childtransform;
    [SerializeField]
    private Transform transformB;
    // Start is called before the first frame update
    void Start()
    {
        posA = childtransform.localPosition;
        posB = transformB.localPosition;
        nextpos = posB;
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    private void move()
    {
        childtransform.localPosition = Vector3.MoveTowards(childtransform.localPosition, nextpos, speed * Time.deltaTime); 
        if(Vector3.Distance(childtransform.localPosition,nextpos)<=0.1)
        {
            changedestination();
        }
    }
    private void changedestination()
    {
        nextpos = nextpos != posA ? posA : posB;
    }
}
