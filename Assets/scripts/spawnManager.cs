using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] Objectler;
    
    [SerializeField] float spawnRate=5f;
    [SerializeField] Transform[] spawnPosition;
    float nextSpawn = 0f;
    timeManager timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = FindObjectOfType<timeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad>nextSpawn && timer.Gameover==false&&timer.Finished==false)
        {
            nextSpawn += spawnRate;
            SpawnObject(Objectler[randomObjects()],spawnPosition[randomSpawn()]);
        }
    }
    void SpawnObject(GameObject spawobject,Transform newTransform)
    {  
        Instantiate(spawobject, newTransform.position, newTransform.rotation);   
    }
    int randomSpawn()
    {
        return Random.Range(0, spawnPosition.Length);
    }
    int randomObjects()
    {
        return Random.Range(0, Objectler.Length);
    }
   
}
