using UnityEngine;
using System.Collections;

public class RealSize : MonoBehaviour
{

    public GameObject obj; 
    private Vector3 scale; 
    private Vector3 newscale; 
    public float newSize =5;
    public float oldSize = 1;
    //public float distanse = 30;
    void Start()
    {
        scale = new Vector3(obj.transform.localScale.x, obj.transform.localScale.y, obj.transform.localScale.z); // Проверяем текущий размер
        newscale = scale;
    }

    void Update()
    {
        bool down = Input.GetKey(KeyCode.Space);
        bool back = Input.GetKey(KeyCode.M);

        //timer -= 1.0f * Time.deltaTime; // 
        obj.transform.localScale = Vector3.Lerp(obj.transform.localScale, newscale, Time.deltaTime);
        if (down)
        {
            newscale = new Vector3(newSize, newSize, newSize); 
          
        }
        if (back)
        {
            newscale = new Vector3(oldSize, oldSize, oldSize);
        }
    }
}