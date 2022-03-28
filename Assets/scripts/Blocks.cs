using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    [SerializeField] bool isColled=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (isColled==false && collision.gameObject.tag=="Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            scoremanager Scores = FindObjectOfType<scoremanager>();
            Scores.score--;
            isColled = true;
        }
        
    }
}
