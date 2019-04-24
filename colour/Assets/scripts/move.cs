using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Vector3 a= Vector3.zero;
    public float fa = 1000f;
    public Rigidbody r;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward* 10 * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
        {
            r.AddForce(new Vector3(-fa * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            r.AddForce(new Vector3(fa* Time.deltaTime, 0, 0));
        }

    }
}
