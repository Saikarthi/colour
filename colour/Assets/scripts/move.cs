using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Vector3 a= Vector3.zero;
    public float fa = 250f;
    public float sa = 5f;
    public Rigidbody r;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // r.AddForce(0, 0, sa * Time.deltaTime);
        //r.transform.Translate(Vector3.forward * Time.deltaTime*sa);
        Vector3 newPosition = new Vector3(0, 0, 5f);
        transform.Translate(newPosition * Time.deltaTime);
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
