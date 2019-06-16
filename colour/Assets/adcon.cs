using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Monetization;

public class adcon : MonoBehaviour
{
    private string store_id = "3187826";
    private string video_ad = "video";
    private string rewardedvideo_ad = "rewardedVideo";
    private string bannerad = "bannerad";
    private int a = 0;
    // Start is called before the first frame update
    void Start()
    {
        Monetization.Initialize(store_id, true);
    }

    // Update is called once per frame
    void Update()
    {
        if(a==1)
        {
            if(Monetization.IsReady(rewardedvideo_ad))
            {
                ShowAdPlacementContent ad = null;
                ad = Monetization.GetPlacementContent(rewardedvideo_ad) as ShowAdPlacementContent;
                if(ad!=null)
                {
                    ad.Show();
                    PlayerPrefs.SetInt("purmain", 10);
                }
            }
            a = 0;


        }
    }
    public void daaa()
    {
        a = 1;
    }
}
