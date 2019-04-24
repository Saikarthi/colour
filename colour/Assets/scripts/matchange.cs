using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matchange : MonoBehaviour
{
    public Material[] mat;
    private int a;
   
    void Start()
    {
        InvokeRepeating("colourchange", 5.0f, 5.0f);
    }

    
    void Update()
    {
        
    }
    void colourchange()
    {
        Debug.Log("hlo");
        if (this.GetComponent<Renderer>().material.color == mat[0].color)
        {
            Debug.Log("hlosccsadsds");
            a = Random.Range(0, 2);
            Debug.Log(a);
            this.GetComponent<Renderer>().material.color = mat[a+1].color;
        }
        else if(this.GetComponent<Renderer>().material.color == mat[1].color)
        {
            a = Random.Range(0, 2);
            if (a == 0)
            {
                this.GetComponent<Renderer>().material.color = mat[a].color;
            }
            if (a == 1)
            {
                this.GetComponent<Renderer>().material.color = mat[a+1].color;
            }

        }
        else if (this.GetComponent<Renderer>().material.color == mat[2].color)
        {
            a = Random.Range(0, 2);
            this.GetComponent<Renderer>().material.color = mat[a].color;
        }
    }
}
