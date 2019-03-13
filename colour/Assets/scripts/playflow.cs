
using UnityEngine;

public class playflow : MonoBehaviour
{
    
    public int fa=0;
    public Transform player;
    public Vector3 a;

    void Update()
    {
        if (fa == 0) {
            transform.position = player.position + a;
        }
        else
        {
            transform.position = player.position;
        }
        
    } 
    public void onc()
    {
        fa = 1; 
    }
}
