using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float Speed = 1;
    void FixedUpdate()
    {
        Quaternion rotationY = Quaternion.AngleAxis(Speed, new Vector3(0, 1, 0));
        transform.rotation *= rotationY;
    }
}
