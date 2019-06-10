using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class track : MonoBehaviour
{

    float timer = 0;
    bool timerCheck = false;
    public score sc1;
    public matchange ma1;
    public int da, sda, ga = 10;

    void Update()
    {
        if (timerCheck)
        {
            timer += Time.deltaTime;
        }
        sc1.sec.text = timer.ToString();
        if (timer >= 2)
        {
            da = int.Parse(sc1.a.text);
            sda = da + ga;

            sc1.a.text = sda.ToString();

            timer = 0;
            

        }
    }

    public void OnCollisionStay(Collision collision)
    {

        if (collision.collider.tag == "gp")
        {

            if (this.GetComponent<Renderer>().material.color == ma1.mat[0].color)
            {
                timerCheck = false;
            }
            if (this.GetComponent<Renderer>().material.color == ma1.mat[1].color)
            {
                timerCheck = false;
            }
            if (this.GetComponent<Renderer>().material.color == ma1.mat[2].color)
            {
                timerCheck = true;
            }

        }
        if (collision.collider.tag == "rp")
        {

            if (this.GetComponent<Renderer>().material.color == ma1.mat[0].color)
            {
                timerCheck = true;
            }
            if (this.GetComponent<Renderer>().material.color == ma1.mat[1].color)
            {
                timerCheck = false;
            }
            if (this.GetComponent<Renderer>().material.color == ma1.mat[2].color)
            {
                timerCheck = false;
            }
        }
        if (collision.collider.tag == "bp")
        {

            if (this.GetComponent<Renderer>().material.color == ma1.mat[0].color)
            {
                timerCheck = false;
            }
            if (this.GetComponent<Renderer>().material.color == ma1.mat[1].color)
            {
                timerCheck = true;
            }
            if (this.GetComponent<Renderer>().material.color == ma1.mat[2].color)
            {
                timerCheck = false;
            }
        }
    }
    void OnCollisionExit(Collision collisionInfo)
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



    }
}
