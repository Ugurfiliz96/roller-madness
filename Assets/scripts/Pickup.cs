using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject deadMotion;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            scoremanager Scores = FindObjectOfType<scoremanager>();
            Scores.score++;
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            scoremanager Scores = FindObjectOfType<scoremanager>();
            Scores.score++;
            Destroy(gameObject);
        }
       
    }
    private void OnDisable()
    {
        Instantiate(deadMotion, transform.position, transform.rotation);
    }
}
