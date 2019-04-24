using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endless : MonoBehaviour
{
    public GameObject[] tileprefab;
    public Transform playertranfrom;
    private float spawnZ = 0.0f;
    private float tilelength = 50.63f;
   private int amttiles = 7;
    private int ran;

    void Start()
    {
        
    }

   
    void Update()
    {
        if(playertranfrom.position.z>(spawnZ-amttiles*tilelength))
        {
            spawntile();
        }
    }

    void spawntile(int prefabindex = -1)
    {
        GameObject go;
        ran = Random.Range(0, 6);
        go = Instantiate(tileprefab[ran]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tilelength;
    }
}
