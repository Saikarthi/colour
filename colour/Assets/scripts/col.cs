using UnityEngine.SceneManagement;
using UnityEngine;

public class col : MonoBehaviour
{
    public move d;
    public score sc;
    public matchange ma;
    public int s;
    public Vector3 cp;




    void OnCollisionEnter(Collision collision)
    {
        
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
            Debug.Log("asd");
            d.enabled = false;


            s = int.Parse(sc.a.text);
            Invoke("SpawnObject", 3);
            
        }
    }
    public void SpawnObject()
    {
        cp = new Vector3(-1.043f, -0.08f, 1f);
        this.transform.position = cp;
        d.enabled = true;
    }

}
