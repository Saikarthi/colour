using UnityEngine.SceneManagement;
using UnityEngine;

public class ui : MonoBehaviour
{
   public void playbutton()
    {
        SceneManager.LoadScene(1);
    }

    public void quitbutton()
    {
        Application.Quit();
    }

}
