using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temp : MonoBehaviour
{
    public Material[] mat;
    private int a;
    public int c = 1;

    void Start()
    {
        // InvokeRepeating("colourchange", 5.0f, 5.0f);
        this.GetComponent<Renderer>().material= mat[1];
    }


    void Update()
    {  //for score
        if (this.GetComponent<Renderer>().material.color == mat[0].color)
        {
            c = 1;

        }
        if (this.GetComponent<Renderer>().material.color == mat[1].color)
        {
            c = 2;

        }
        if (this.GetComponent<Renderer>().material.color == mat[2].color)
        {
            c = 3;

        }
    }
    void colourchange()
    {

        if (this.GetComponent<Renderer>().material.color == mat[0].color)
        {


            a = Random.Range(0, 2);

            this.GetComponent<Renderer>().material.color = mat[a + 1].color;




        }
        else if (this.GetComponent<Renderer>().material.color == mat[1].color)
        {
            a = Random.Range(0, 2);
            if (a == 0)
            {

                this.GetComponent<Renderer>().material.color = mat[a].color;


            }
            if (a == 1)
            {

                this.GetComponent<Renderer>().material.color = mat[a + 1].color;

            }





        }
        else if (this.GetComponent<Renderer>().material.color == mat[2].color)
        {
            a = Random.Range(0, 2);
            this.GetComponent<Renderer>().material.color = mat[a].color;




        }


    }
}