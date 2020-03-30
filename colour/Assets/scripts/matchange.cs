using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matchange : MonoBehaviour
{
    public Material[] mat;
    private int a;
    public col daa;
    public int c=1;

    void Start()
    {
        InvokeRepeating("colourchange", 2.0f, 2.0f);
        
    }


    void Update()
    {  //for score
        if (this.GetComponent<Renderer>().material== mat[0])
        {
            c = 1;
            
        }
        if (this.GetComponent<Renderer>().material== mat[1])
        {
            c = 2;
           
        }
        if (this.GetComponent<Renderer>().material == mat[2])
        {
            c = 3;
          
        }
    }
    void colourchange()
    {

        if (this.GetComponent<Renderer>().material == mat[0])
        {
           
            
            a = Random.Range(0, 2);

            this.GetComponent<Renderer>().material = mat[a + 1];
            
            


        }
        else if (this.GetComponent<Renderer>().material == mat[1])
        {
            a = Random.Range(0, 2);
            if (a == 0)
            {
                
                this.GetComponent<Renderer>().material = mat[a];

                
            }
            if (a == 1)
            {
               
                this.GetComponent<Renderer>().material = mat[a + 1];
                
            }
           
            



        }
        else if (this.GetComponent<Renderer>().material == mat[2])
        {
            a = Random.Range(0, 2);
            this.GetComponent<Renderer>().material = mat[a];
               

            


        }
       
       
    }
}
