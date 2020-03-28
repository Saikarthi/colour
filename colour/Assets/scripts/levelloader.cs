using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelloader : MonoBehaviour
{

    public GameObject loadscreen;
    public Slider s;
    public Text t;
    public void loadlevel(int sindex)
    {
        StartCoroutine(loadasyn(sindex));


    }

    IEnumerator loadasyn (int sindex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sindex);
        loadscreen.SetActive(true);
        while(!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);

            s.value = progress;
            t.text = progress * 100f + "%";

            yield return null;
        }

    }

}
