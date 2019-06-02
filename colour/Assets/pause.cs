using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public static bool gameispause = false;
    public GameObject pausemenu;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void resume()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
    }


    public void pause1()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 0f;
        gameispause = true;
    }
    public void quit()
    {
        Application.Quit();
    }
    public void replay()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
}