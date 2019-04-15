using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermotor : MonoBehaviour
{
    private CharacterController can;
    public float a = 5.0f;
  
    private Vector3 movevector;


    void Start()
    {
        can = GetComponent<CharacterController>();
    }

   
    void Update()
    {
        movevector = Vector3.zero;
        if (Input.GetKey(KeyCode.A))
        {
           movevector = new Vector3(-0.2f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
           movevector = new Vector3(0.2f, 0, 0);
       }

        can.Move(Vector3.forward*a );
       can.Move(movevector);
    }
}
