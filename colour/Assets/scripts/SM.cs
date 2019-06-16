using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Monetization;

public class SM : MonoBehaviour
{
    private string video_ad = "video";
    private string bannerad = "bannerad";
    private string store_id = "3187826";
    void Start()
    {
        Monetization.Initialize(store_id, true);
    }
    public void kaaaaaaa()
    {

        int a =Random.Range(0, 2);
        if (a == 1)
        {
            if (Monetization.IsReady(video_ad))
            {
                ShowAdPlacementContent ad = null;
                ad = Monetization.GetPlacementContent(video_ad) as ShowAdPlacementContent;
                if (ad != null)
                {
                    ad.Show();
                    
                }
            }
        }

        if (a == 1)
        {
            if (Monetization.IsReady(bannerad))
            {
                ShowAdPlacementContent ad = null;
                ad = Monetization.GetPlacementContent(bannerad) as ShowAdPlacementContent;
                if (ad != null)
                {
                    ad.Show();
                    
                }
            }
        }
        SceneManager.LoadScene(0);
    }
}
