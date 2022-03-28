using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    Transform Target;
    [SerializeField] GameObject deadMotion;
    [SerializeField] float hiz=3f,stopDistance=2f;
    // Start is called before the first frame update
    void Start()
    {
        Target=GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Target!=null)
        {
            transform.LookAt(Target.position);
            float mesafe = Vector3.Distance(transform.position, Target.position);
            if (mesafe > stopDistance)
            {
                transform.position += transform.forward * Time.deltaTime * hiz;
            }
        }
        
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            
            Destroy(collision.gameObject);
            timeManager timemanage = FindObjectOfType<timeManager>();
            timemanage.Gameover = true;
        }
    }
    private void OnDisable()
    {
        Instantiate(deadMotion, transform.position, transform.rotation);
    }
}
