using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tr : MonoBehaviour
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
        if (collision.collider.tag == "rb")
        {

            timerCheck = true;
            Debug.Log("!");
        }
    }
    void OnCollisionExit(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "rb")
        {

            timerCheck = false;
            Debug.Log("ka");
        }
      
    }
}
