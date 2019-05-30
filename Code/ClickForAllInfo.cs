using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickForAllInfo : MonoBehaviour
{

    public Text myText;
    public GameObject panel;

    private void Start()
    {
        myText.enabled = false;
        panel.SetActive(false);
    }

    void Update()
    {
        bool pressedAllInfo = Input.GetKey(KeyCode.R);
        bool pressedClose = Input.GetKey(KeyCode.Z);

        if (pressedAllInfo)
        {
            myText.enabled = true;
            panel.SetActive(true);
            myText.text = "Клавіші:\nWhiteSpace - реальні розміри;\nM-повернення до " +
                "звичайних розмірів;\nN - реальні відстані;\nB - повернення до звичайних розмірів;\n" +
                "G - прискоренння часу в 5 разів;\n" +
                "1 - інформація про Меркурій;\n" +
                "2 - інформація про Венеру;\n" +
                "3 - інформація про Землю;\n" +
                "4 - інформація про Місяць;\n" +
                "5 - інформація про Марс;\n" +
                "6 - інформація про Юпітер;\n" +
                "7 - інформація про Сатурн;\n" +
                "8 - інформація про Уран;\n" +
                "9 - інформація про Нептун;\n" +
                "0 - закрити інформаційне табло;\n" +
                "Z - закрити цю вкладку.";
        }
        if (pressedClose)
        {
            myText.enabled = false;
            panel.SetActive(false);
        }

    }
}
