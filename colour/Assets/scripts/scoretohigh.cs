using System.Collections;
using System.Collections.Generic;
using CloudOnce;
using UnityEngine;
using UnityEngine.UI;

public class scoretohigh : MonoBehaviour
{
    public scoreend da;
   
    void Update()
    {
        if(da.gada==1)
        {
            Leaderboards.highscore.SubmitScore(da.ha);
        }
    }
}
