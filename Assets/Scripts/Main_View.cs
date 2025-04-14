using System.Diagnostics;
using TMPro;
using UnityEngine;

public class Main_View : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Player.money_display.SetText(Player.money.ToString());
    }
}
