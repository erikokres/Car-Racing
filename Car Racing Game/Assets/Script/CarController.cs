using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float maxSpeed;


    public Rigidbody theRB;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theRB.AddForce(new Vector3(0f, 0f, 10f));

        transform.position = theRB.position;
    }
}
