using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreend : MonoBehaviour
{
    public score sc;
    public Text avm;
    public int mn,gada=0,ha;
    public GameObject avm1;
    public matchange a;
    public track b;
    public col c;
    public score d;
    public move e;
    
    void Start()
    {

    }

  
    void Update()
    {

        mn = int.Parse(sc.a.text);
        if (mn <= 0)
        {
            a.enabled = false;
            b.enabled = false;
            c.enabled = false;
            d.enabled = false;
            e.enabled = false;
            gada = 1;
            sc.a.text = 0.ToString();
            avm1.SetActive(true);
            avm.text = sc.dis.text;
            ha = int.Parse(avm.text);
           
        }
    }
    
}
