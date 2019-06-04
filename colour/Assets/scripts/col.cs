using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class col : MonoBehaviour
{
    public move d;
    public score sc;
    public Transform pa;
    public matchange ma;
    public track fg;
    public int s, ga, da, sda, fds, asdf = 1, mn;
    public float baa = 0,caa;
    public Vector3 cp;
    //  public float timer = 0;
    // public bool timerCheck = false;

    void Update()
    {

        /* if (timerCheck)
         {
             timer += Time.deltaTime;
             // mn = (int)Math.Ceiling(timer);
             //  Debug.Log(fds);

             if (asdf == 0)
             {

                 timer = 0;
             }
             sc.sec.text = timer.ToString();

         }


         if (timer >= 3)
         {
             da = int.Parse(sc.a.text);
             sda = da + ga;

             sc.a.text = sda.ToString();

             timer = 0;
             Debug.Log(timer);

         }*/
        mn = int.Parse(sc.a.text);
        if (mn <= 0)
        {
            sc.a.text = 0.ToString();
        }



    }




    /*void OnCollisionExit(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "gp")
        {

            timer = 0;



        }
        if (collisionInfo.collider.tag == "bp")
        {

            timer = 0;

        }
        if (collisionInfo.collider.tag == "rp")
        {

            timer = 0;



        }



    }*/

    void OnCollisionEnter(Collision collision)
    {

        /* if (collision.collider.tag == "gp")
         {

             if (this.GetComponent<Renderer>().material.color == ma.mat[0].color)
             {
                 timerCheck = false;
             }
             if (this.GetComponent<Renderer>().material.color == ma.mat[1].color)
             {
                 timerCheck = false;
             }
             if (this.GetComponent<Renderer>().material.color == ma.mat[2].color)
             {
                 timerCheck = true;
             }

         }
         if (collision.collider.tag == "rp")
         {

             if (this.GetComponent<Renderer>().material.color == ma.mat[0].color)
             {
                 timerCheck = true;
             }
             if (this.GetComponent<Renderer>().material.color == ma.mat[1].color)
             {
                 timerCheck = false;
             }
             if (this.GetComponent<Renderer>().material.color == ma.mat[2].color)
             {
                 timerCheck = false;
             }
         }
         if (collision.collider.tag == "bp")
         {

             if (this.GetComponent<Renderer>().material.color == ma.mat[0].color)
             {
                 timerCheck = false;
             }
             if (this.GetComponent<Renderer>().material.color == ma.mat[1].color)
             {
                 timerCheck = true;
             }
             if (this.GetComponent<Renderer>().material.color == ma.mat[2].color)
             {
                 timerCheck = false;
             }
         }*/

        if (ma.c == 1)
        {
            //red
            if (collision.collider.tag == "r")
            {

                int a = 10;
                int b = int.Parse(sc.a.text);
                //sc.a.text= sc.a.text-a;
                int c = b - a;

                sc.a.text = c.ToString();

            }
            if (collision.collider.tag == "b")
            {



                int a = 50;
                int b = int.Parse(sc.a.text);
                //sc.a.text= sc.a.text-a;
                int c = b - a;

                sc.a.text = c.ToString();


            }
            if (collision.collider.tag == "g")
            {



                int a = 50;
                int b = int.Parse(sc.a.text);
                //sc.a.text= sc.a.text-a;
                int c = b - a;

                sc.a.text = c.ToString();


            }
        }
        //blue

        if (ma.c == 2)
        {
            if (collision.collider.tag == "r")
            {


                int a = 50;
                int b = int.Parse(sc.a.text);
                //sc.a.text= sc.a.text-a;
                int c = b - a;

                sc.a.text = c.ToString();

            }
            if (collision.collider.tag == "b")
            {



                int a = 10;
                int b = int.Parse(sc.a.text);
                //sc.a.text= sc.a.text-a;
                int c = b - a;

                sc.a.text = c.ToString();


            }
            if (collision.collider.tag == "g")
            {



                int a = 50;
                int b = int.Parse(sc.a.text);
                //sc.a.text= sc.a.text-a;
                int c = b - a;

                sc.a.text = c.ToString();


            }
        }
        //green
        if (ma.c == 3)
        {
            if (collision.collider.tag == "r")
            {


                int a = 50;
                int b = int.Parse(sc.a.text);
                //sc.a.text= sc.a.text-a;
                int c = b - a;

                sc.a.text = c.ToString();

            }
            if (collision.collider.tag == "b")
            {



                int a = 50;
                int b = int.Parse(sc.a.text);
                //sc.a.text= sc.a.text-a;
                int c = b - a;

                sc.a.text = c.ToString();


            }
            if (collision.collider.tag == "g")
            {



                int a = 10;
                int b = int.Parse(sc.a.text);
                //sc.a.text= sc.a.text-a;
                int c = b - a;

                sc.a.text = c.ToString();


            }




        }

        if (collision.collider.tag == "g" || collision.collider.tag == "b" || collision.collider.tag == "r")
        {

            d.enabled = false;

            // asdf = 0;
           // s = int.Parse(sc.a.text);
            fg.enabled = false;
            caa= pa.position.z;
            Invoke("SpawnObject", 3);

        }
    }
    public void SpawnObject()
    {
        
        //  asdf = 1;
        cp = new Vector3(-1.043f, -0.08f, 1f);
        this.transform.position = cp;
        score23();
        fg.enabled = true;
        d.enabled = true;
    }
    public void score23()
    {
        baa += caa;
    }
}