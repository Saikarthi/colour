using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class count : MonoBehaviour
{
    public Text count1, a;
    public GameObject g;
    public float time=3f;
    void Update()
    {
        time -= 1 * Time.deltaTime;
        count1.text = time.ToString("0");
        if(time<=0)
        {
            g.SetActive(false);
            
        }
    }

}

