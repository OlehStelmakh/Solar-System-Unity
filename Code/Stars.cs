using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour
{
    public GameObject obj;
    public float rangeX1 = -1000f;
    public float rangeX2 = 1000f;
    public float rangeY1 = -1000f;
    public float rangeY2 = 1000f;
    public float rangeZ1 = 300f;
    public float rangeZ2 = 450f;
    public float speed = 0.1f;
    public int quantityOfStars = 300;

    void Start()
    {
        StartCoroutine(instObj());
    }
    IEnumerator instObj ()
    {
        int i = 0;
        while (i<quantityOfStars) {
            Instantiate(obj, new Vector3(Random.Range(rangeX1, rangeX2), Random.Range(rangeY1, rangeY2), Random.Range(rangeZ1, rangeZ2)), Quaternion.identity);
            yield return new WaitForSeconds(speed);
        }
    }
}
