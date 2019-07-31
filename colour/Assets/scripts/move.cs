using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Vector3 a= Vector3.zero;
    public float fa = 250f;
    public float sa = 12f;
    public Rigidbody r;


    
    void FixedUpdate()
    {
       
        Vector3 newPosition = new Vector3(0, 0,sa);
      
        transform.position += newPosition * Time.deltaTime;
         if (Input.GetKey(KeyCode.A))
          {
              r.AddForce(-fa * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
          }
          if (Input.GetKey(KeyCode.D))
          {
              r.AddForce(fa* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
          }
        float tilt = Input.acceleration.x;
       
        transform.position += new Vector3(tilt/10,0,0);

    }
}
