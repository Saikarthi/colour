using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inapp : MonoBehaviour
{
    public int asdf = 0;
   
    void Start()
    {
        PlayerPrefs.SetInt("purmain", asdf);
    }

    
    void Update()
    {
        
    }
    public void BuyComplete(UnityEngine.Purchasing.Product product)
    {
        Debug.Log("purchase complete");
        asdf = 50;
        PlayerPrefs.SetInt("purmain",asdf);

    }
    public void BuyFalied(UnityEngine.Purchasing.Product product,UnityEngine.Purchasing.PurchaseFailureReason failureReason)
    {
        Debug.Log("purchase fail");
    }



}
