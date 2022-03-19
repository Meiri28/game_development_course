using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float movementSpeed = 0.5f;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float horizontaMovment = (target.position.x - transform.position.x) / Math.Abs(target.position.x - transform.position.x);
        //float verticalMovment = (target.position.z - transform.position.z) / Math.Abs(target.position.z - transform.position.z);
        Vector3 dir = (target.position - transform.position).normalized;
        //face_forward_target();
        transform.position += (dir *  movementSpeed * Time.deltaTime);
    }

    void face_forward_target()
    {
        //Quaternion q = Quaternion.FromToRotation(-LinkedPortal.transform.parent.forward, transform.parent.forward);
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

}
