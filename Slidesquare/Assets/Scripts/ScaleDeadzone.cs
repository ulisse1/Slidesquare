using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleDeadzone : MonoBehaviour
{
    public Transform ground;
    public Transform deadzone;
    
    void Awake()
    {
        deadzone.localScale = new Vector3(ground.localScale.x + 0.1f, ground.localScale.y, ground.localScale.z);
        deadzone.localPosition = new Vector3(ground.localPosition.x, ground.localPosition.y - 0.05f, ground.localPosition.z);
    }
    
}
