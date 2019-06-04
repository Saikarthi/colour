using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text a,sec,dis;
    public int s;
    public Transform p;
    public col daa;

    void Start()
    {
        a.text = 100.ToString();
        

    }

    
    void Update()
    {
        float ab = p.position.z;
        dis.text = ab.ToString("0");
    }
    
}
