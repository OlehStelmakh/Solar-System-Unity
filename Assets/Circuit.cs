using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circuit : MonoBehaviour
{
    public Transform aroundPoint;
    private float circleForEdit;
    public float circleInSecond = 1f;
    public float circleInSecondx5 = 5f;

    public float offsetSin = 1;
    public float offsetCos = 1;

    float dist;
    float circleRadians = Mathf.PI / 2;
    float currentAng = 0;

    public float realDistanse = 0;
    public float oldDistanse = 0;

    void Start()
    {
        dist = (transform.position - aroundPoint.position).magnitude;
        circleForEdit = circleInSecond;
    }

    void Update()
    {
        bool down = Input.GetKey(KeyCode.N);
        bool back = Input.GetKey(KeyCode.B);
        bool speedx5 = Input.GetKey(KeyCode.G);
        Vector3 p = aroundPoint.position;
        p.x += Mathf.Sin(currentAng) * dist * offsetSin;
        p.z += Mathf.Cos(currentAng) * dist * offsetCos;
        transform.position = p;

        if (down)
        {
            dist = realDistanse;
        }
        if (back)
        {
            dist = oldDistanse;
        }
        if (speedx5)
        {
            circleForEdit = circleInSecondx5;
        }
        if (!speedx5)
        {
            circleForEdit = circleInSecond;
        }
        currentAng += circleRadians * circleForEdit * Time.deltaTime;
    }
}
