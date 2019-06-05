using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public static bool gameispause = false;
    public GameObject pausemenu,c;

    void Start()
    {

    }
   
    void Update()
    {

    }
    public void resume()
    {
        
        Time.timeScale = 1f;
    }


    public void pause1()
    {
        
        Time.timeScale = 0f ;
        
    }
    public void quit()
    {
        Application.Quit();
    }
    public void replay()
    {
        
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    private void OnApplicationPause(bool pause1)
    {
        if(pause1==true)
         { c.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}