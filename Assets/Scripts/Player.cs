using System;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;

[Serializable]
[XmlRoot("Player")]
public class PlayerFields
{
    [XmlElement("day")]
    public int day;
    [XmlElement("money")]
    public int money { get; set; }
    [XmlIgnore]//[XmlElement("status")]
    public string status;
    [XmlIgnore]
    public TextMeshPro money_display1;
    [XmlIgnore]
    public TextMeshPro money_display2;
}


public class Player : MonoBehaviour
{
    public static PlayerFields fields = new PlayerFields();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fields.day = 1;
        fields.money = 1300;
        fields.status = null;
        fields.money_display1=GameObject.Find("Money1").GetComponent<TextMeshPro>();
        fields.money_display2 = GameObject.Find("Money2").GetComponent<TextMeshPro>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
