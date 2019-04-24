using UnityEngine.SceneManagement;
using UnityEngine;

public class col : MonoBehaviour
{
    public move d;
    
   

    
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "r"|| collision.collider.tag == "b"|| collision.collider.tag == "g") {
            d.enabled = false;
            
           
            Invoke("re", 2f);


        }
       
    }
    public void re()

    {
        SceneManager.LoadScene(0);
    }
}
