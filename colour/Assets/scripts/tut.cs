using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class tut : MonoBehaviour
{
    public GameObject a, b;
    // Start is called before the first frame update
    void Start()
    {
       if (PlayerPrefs.GetInt("FIRSTTIMEOPENING", 1) == 1)
        {
            Debug.Log("First Time Opening");
            a.SetActive(true);
            Invoke("adad", 5);
            

           PlayerPrefs.SetInt("FIRSTTIMEOPENING", 0);

            //Do your stuff here

       }
    }
    public void adad()
    {
        
        a.SetActive(false);
        b.SetActive(true);
        Invoke("adad1", 5);

    }
    public void adad1()
    {
        SceneManager.LoadScene(2);

       

    }
}
