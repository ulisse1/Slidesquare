using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 5f;
    private Vector3 vector;

    void Start()
    {
        vector = transform.right * moveSpeed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!(Physics.Raycast(transform.position + Vector3.right, -Vector3.up)) ||
            !(Physics.Raycast(transform.position - Vector3.right, -Vector3.up)))
        {
            vector *= -1;
        }

        rb.position += vector * Time.fixedDeltaTime;

    }
}
