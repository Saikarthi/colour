using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class after5sec : MonoBehaviour
{
    public matchange a;
    public track b;
    public col c;
    public score d;
    public move e;
    void Start()
    {
      
        a.enabled = false;
        b.enabled = false;
        c.enabled = false;
        d.enabled = false;
        e.enabled = false;


        Invoke("insec", 2);
    }

    void insec()
    {
        a.enabled = true;
        b.enabled = true;
        c.enabled = true;
        d.enabled = true;
        e.enabled = true;

    }
}
