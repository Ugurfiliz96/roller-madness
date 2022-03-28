using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    [SerializeField] Transform Target;
    private Vector3 mesafe;
    [SerializeField] float FLspeed=5f; 
    // Start is called before the first frame update
    void Start()
    {
        mesafe=KameraTakip(Target);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Target != null)
        {
            FollowThePlayer();
        }
    }
    void FollowThePlayer()
    {
        
        Vector3 Hedefpozisyon = Target.position + mesafe;
        transform.position = Vector3.Lerp(transform.position, Hedefpozisyon, FLspeed * Time.deltaTime);
        transform.LookAt(Target.transform.position);
    }

    private Vector3 KameraTakip(Transform newTarget)
    {
        return transform.position - newTarget.position;
    }
}
