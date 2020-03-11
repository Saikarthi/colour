
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main : MonoBehaviour
{

    public GameObject a, b;

    void Update()
    {
        
    }
    public void start()
    {
        if (PlayerPrefs.GetInt("FIRSTTIMEOPENING", 1) == 1)
        {
            SceneManager.LoadScene(1);
        

        PlayerPrefs.SetInt("FIRSTTIMEOPENING", 0);

           

        }
        else
        {
            SceneManager.LoadScene(1);
        }

 

        
    }

    public void help()
    {

        a.SetActive(true);
        Invoke("adad", 5);


    }
    public void adad()
    {

        a.SetActive(false);
        b.SetActive(true);
        Invoke("adad1", 5);

    }
    public void adad1()
    {
        b.SetActive(false);
      
       



    }
    public void quit()
    {
        Application.Quit();
    }
}
