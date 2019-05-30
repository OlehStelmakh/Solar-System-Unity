using UnityEngine;

public class PlanetName : MonoBehaviour
{

    public string objectName;
    public float objectSize = 2;

    private bool showName;
    private Vector3 position;

    public int textSize = 14;
    public Font textFont;
    public Color textColor = Color.white;
    public float textHeight = 10f;

    public void Awake()
    {
        if (string.IsNullOrEmpty(objectName))
        {
            objectName = name;
        }
    }

    public void Update()
    {
        showName = false;
        Vector3 cameraRelative = Camera.main.transform.InverseTransformPoint(transform.position);
        if (cameraRelative.z > 0) {
            Vector3 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
            position = new Vector3(screenPosition.x - 60f, Screen.height - (screenPosition.y + textHeight), position.z);
            showName = true;
        }
    }

    public void OnGUI()
    {
        if (showName)
        {
            GUIStyle label = new GUIStyle(GUI.skin.label);
            label.alignment = TextAnchor.MiddleCenter;
            label.fontSize = textSize;
            label.normal.textColor = textColor;
            label.alignment = TextAnchor.MiddleCenter;
            GUI.Label(new Rect(position.x, position.y, 120f, 20f), objectName, label);
        }
    }


}