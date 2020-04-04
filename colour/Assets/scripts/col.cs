using UnityEngine.SceneManagement;
using UnityEngine;
using System;
using UnityEngine.UI;

public class col : MonoBehaviour
{
    public move d;
    public score sc;
    public Transform pa;
    public matchange ma;
    public track fg;
 
    public int s, ga, da, sda, fds, asdf = 1;
    public float baa = 0,caa;
    public Vector3 cp;

  





    void OnCollisionEnter(Collision collision)
    {

       

        if (ma.c == 1)
        {
          
            if (collision.collider.tag == "r")
            {
                Debug.Log("11111");
                int a = 10;
                int b = int.Parse(sc.a.text);
          
                int c = b - a;

                sc.a.text = c.ToString();

            }
            if (collision.collider.tag == "b")
            {



                int a = 50;
                int b = int.Parse(sc.a.text);
               
                int c = b - a;

                sc.a.text = c.ToString();


            }
            if (collision.collider.tag == "g")
            {



                int a = 50;
                int b = int.Parse(sc.a.text);
               
                int c = b - a;

                sc.a.text = c.ToString();


            }
        }
      

        if (ma.c == 2)
        {
            if (collision.collider.tag == "r")
            {


                int a = 50;
                int b = int.Parse(sc.a.text);
               
                int c = b - a;

                sc.a.text = c.ToString();

            }
            if (collision.collider.tag == "b")
            {



                int a = 10;
                int b = int.Parse(sc.a.text);
        
                int c = b - a;

                sc.a.text = c.ToString();


            }
            if (collision.collider.tag == "g")
            {



                int a = 50;
                int b = int.Parse(sc.a.text);
             
                int c = b - a;

                sc.a.text = c.ToString();


            }
        }

        if (ma.c == 3)
        {
            if (collision.collider.tag == "r")
            {


                int a = 50;
                int b = int.Parse(sc.a.text);
    
                int c = b - a;

                sc.a.text = c.ToString();

            }
            if (collision.collider.tag == "b")
            {



                int a = 50;
                int b = int.Parse(sc.a.text);
     
                int c = b - a;

                sc.a.text = c.ToString();


            }
            if (collision.collider.tag == "g")
            {



                int a = 10;
                int b = int.Parse(sc.a.text);
            
                int c = b - a;

                sc.a.text = c.ToString();


            }




        }

        if (collision.collider.tag == "g" || collision.collider.tag == "b" || collision.collider.tag == "r")
        {

            d.enabled = false;

         
            fg.enabled = false;
            ma.enabled = false;
            caa= pa.position.z;
            Invoke("SpawnObject", 0.5f);

        } 
    }
    public void SpawnObject()
    {
        

        cp = new Vector3(-1.043f, -0.08f, 30.36f);
        this.transform.position = cp;
        score23();
        fg.enabled = true;
        ma.enabled = true;
        d.enabled = true;
    }
    public void score23()
    {
        baa += caa;
    }
}