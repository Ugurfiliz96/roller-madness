using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] float speed;
    private Vector3 yon;
    Rigidbody rb;
    timeManager timer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        timer = FindObjectOfType<timeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.Gameover==false && timer.Finished==false)
        {
            MoveToPlayer();
        }
        if (timer.Gameover && timer.Finished)
        {
            rb.isKinematic=true;
            
        }
       
    }
    void MoveToPlayer()
    {
        float yonx = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float yonz = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        //transform.position += yon;
        yon = new Vector3(yonx, 0f, yonz);
        rb.AddForce(yon);
    }
    
}
