using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float movementSpeed = 4000f;

    // Update is called once per frame
    void FixedUpdate()
    {
        //Keeps constant speed.
        rb.position = rb.position + Vector3.back * movementSpeed * Time.fixedDeltaTime;
    }

    void OnTriggerEnter(Collider objectInfo)
    {
        if(objectInfo.tag == "Deadzone")
        {
            Destroy(gameObject);
        }
        
    }

}
