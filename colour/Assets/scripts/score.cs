using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text a,sec,dis;
    public int s;
    public Transform p;

    void Start()
    {
        a.text = 100.ToString();
        

    }

    
    void Update()
    {

        dis.text = p.position.z.ToString("0");
    }
    
}
