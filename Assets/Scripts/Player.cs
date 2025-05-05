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
    public TextMeshPro money_display;
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
        fields.money_display=GameObject.Find("Money").GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
