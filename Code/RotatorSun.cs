using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorSun : MonoBehaviour
{

    public float speed = 1f;
    void FixedUpdate()
    {
        Quaternion rotationY = Quaternion.AngleAxis(speed, new Vector3(0, 0, 1));
        transform.rotation *= rotationY;
    }
}
