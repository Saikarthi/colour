using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text a,sec,dis;
    public int pur=0;
    public int asd;
    public int s;
    public Transform p;
    public col daa;
    public float ab;

    void Start()
    {
        pur = PlayerPrefs.GetInt("purmain");
        asd = 100 + pur;
        a.text = asd.ToString();
        

    }

    
    void Update()
    {
        ab = p.position.z+daa.baa;
        dis.text = ab.ToString("0");
        
       // DontDestroyOnLoad(GameObject.find)
    }
   

}
