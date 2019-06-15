using CloudOnce;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main : MonoBehaviour
{
  
    void Start()
    {
        Cloud.OnInitializeComplete += CloudOnceInitializeComplete;
        Cloud.Initialize(false, true);

    }
    public void CloudOnceInitializeComplete()
    {
        Cloud.OnInitializeComplete -= CloudOnceInitializeComplete;
        Debug.LogWarning("Initialize");

    }

    void Update()
    {
        
    }
    public void start()
    {

             SceneManager.LoadScene(1);
    }
    
    public void quit()
    {
        Application.Quit();
    }
}
