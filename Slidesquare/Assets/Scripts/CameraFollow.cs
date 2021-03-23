using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform playerPos;
    public Vector3 offset;
    //private float tiltAngle = 60f;
    //private float smooth = 5f;
    void Update()
    {
        
        transform.position = playerPos.position + offset;
        
        //Strafe effect
        /*
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        Quaternion target = Quaternion.Euler(0, 0, tiltAroundZ);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
        */

        //Rotate around camera's Z axis
        //transform.eulerAngles -= new Vector3(0, 0, -0.01f);
    }
}
