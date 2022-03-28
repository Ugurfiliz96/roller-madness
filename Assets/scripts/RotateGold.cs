using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGold : MonoBehaviour
{
    [SerializeField] Vector3 yonler;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(yonler,Space.World);
    }
}
