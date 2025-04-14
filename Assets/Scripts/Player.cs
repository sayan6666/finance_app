using System;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int day;
    public static int money { get; set; }
    public string status;
    public static TextMeshPro money_display;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        day = 1;
        money = 1300;
        status = null;
        money_display=GameObject.Find("Money").GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
