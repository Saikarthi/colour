using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Vector3 a= Vector3.zero;
    public float fa = 250f;
    public float sa = 1500f;
    public Rigidbody r;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        r.AddForce(0, 0, sa * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
        {
            r.AddForce(-fa * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            r.AddForce(fa* Time.deltaTime, 0, 0);
        }

    }
}
