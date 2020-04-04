using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camflow : MonoBehaviour
{
    public Transform player;
    public Vector3 a;
   
    void Update()
    {
      
            transform.position = player.position + a;
      
    }
}
