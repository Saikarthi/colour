using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENDLESS : MonoBehaviour
{
    public GameObject[] tileprefab;
    public Transform playertranfrom;
    private float spawnZ = 0.0f;
    [SerializeField]
    private float tilelength = 1000f;
    private int amttiles = 7;
    private int ran;

    void Start()
    {
        spawntile(1);
    }


    void Update()
    {
        if (playertranfrom.position.z > (spawnZ - amttiles * tilelength))
        {
            spawntile();
        }
    }

    void spawntile(int prefabindex = -1)
    {
        GameObject go;
        ran = Random.Range(0, 0);
        if (prefabindex == 1)
        {
            go = Instantiate(tileprefab[0]) as GameObject;
            go.transform.SetParent(transform);
            go.transform.position = Vector3.forward * spawnZ;
            spawnZ += tilelength;
        }
        else
        {
            go = Instantiate(tileprefab[ran]) as GameObject;
            go.transform.SetParent(transform);
            go.transform.position = Vector3.forward * spawnZ;
            spawnZ += tilelength;
        }
    }
}
