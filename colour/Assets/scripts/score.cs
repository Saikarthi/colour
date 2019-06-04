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
    public float ab;

    void Start()
    {
        a.text = 100.ToString();
        

    }

    
    void Update()
    {
        ab = p.position.z+daa.baa;
        dis.text = ab.ToString("0");
    }
    
}
