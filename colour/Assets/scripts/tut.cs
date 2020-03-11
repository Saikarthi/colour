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
        SceneManager.LoadScene(2);



    }
}
