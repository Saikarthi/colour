using CloudOnce;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main : MonoBehaviour
{
    // Start is called before the first frame update
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

    // Update is called once per frame
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
