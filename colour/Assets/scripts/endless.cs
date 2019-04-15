using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endless : MonoBehaviour
{
    public GameObject tileprefab;
    public Transform playertranfrom;
    private float spawnZ = 0.0f;
    private float tilelength = 50.63f;
   private int amttiles =3; 

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

    void spawntile(int prefabindex =-1)
    {
        GameObject go;
        go = Instantiate(tileprefab) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += tilelength;
    }
}
