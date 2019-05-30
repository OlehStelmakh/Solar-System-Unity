using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTime : MonoBehaviour
{

    public static bool stop;
    public static string result;
    public int startMonth, startYear;
    public Text textOutput;
    public bool startAwake = true;
    private int month, year;
    private string y, m;
    private float speedForEdit;
    public float speed = 0.8f;
    public float speedx5variable = 0.16f;

    void Awake()
    {
        if (startAwake) stop = false; else stop = true;
        if (startMonth > 1 && startMonth <= 12) month = startMonth; else startMonth = 2;
        if (startYear >= 1960 && startYear <= 3000) year = startYear; else startYear = 1962;
    }

    void Start()
    {
        StartCoroutine(RepeatingFunction());
        speedForEdit = speed;
    }

    IEnumerator RepeatingFunction()
    {
        while (true)
        {
            if (!stop) TimeCount();
            yield return new WaitForSeconds(speedForEdit);
        }
    }

    void TimeCount()
    {
        if (month > 12)
        {
            month = 1;
            year++;
        }
        CurrentTime();
        month++;
    }

    void CurrentTime()
    {
        if (month < 10) m = "0" + month; else m = month.ToString();
        if (year < 1000) y = "0" + year; else y = year.ToString();
    }

    void OnGUI()
    {
        result = m + " month," + y + " year";
        textOutput.text = result;
    }

    public void Update()
    {
        bool speedx5 = Input.GetKey(KeyCode.G);
        if (speedx5)
        {
            speedForEdit = speedx5variable;
        }
        if (!speedx5)
        {
            speedForEdit = speed;
        }
    }
}