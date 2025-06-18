using SQLite4Unity3d;
using System;
using TMPro;
using UnityEngine;

[Table("Player")]
public class PlayerFields
{
    [PrimaryKey, AutoIncrement]
    [Column("id")]
    public int id { get; set; }
    [Column("day")]
    public int day { get; set; }
    [Column("money")]
    public int money { get; set; }
    [Column("status")]
    public int status { get; set; }
    [Column("message_history")]
    public string message_history { get; set; }
    [Column("last_message")]
    public int last_message { get; set; }
    [Ignore]
    public TextMeshPro money_display1 { get; set; }
    [Ignore]
    public TextMeshPro money_display2 { get; set; }
    [Ignore]
    public TextMeshPro money_display3 { get; set; }
    [Ignore]
    public TextMeshPro money_display4 { get; set; }
}


public class Player : MonoBehaviour
{
    public static PlayerFields fields = new PlayerFields();

    public static void Retrieve_Obj()
    {
        fields.money_display1 = GameObject.Find("Money1").GetComponent<TextMeshPro>();
        fields.money_display2 = GameObject.Find("Money2").GetComponent<TextMeshPro>();
        fields.money_display3 = GameObject.Find("Money3").GetComponent<TextMeshPro>();
        fields.money_display4 = GameObject.Find("Money4").GetComponent<TextMeshPro>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fields.day = 1;
        fields.money = 17000;
        fields.status = 1;
        fields.message_history = "";
        fields.last_message = 1;
        Retrieve_Obj();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
