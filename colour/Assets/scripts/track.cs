﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class track : MonoBehaviour
{

    float timer = 0;
    bool timerCheck = false;
  

    void Update()
    {
        if (timerCheck)
        {
            timer += Time.deltaTime;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "rp")
        {
           // timerCheck = true;
           
        }
    }
    void OnCollisionExit(Collision col)
    {
        if (col.collider.tag == "rp")
        {
            timerCheck = false;
          
        }
    }
}
