using System;
using TMPro;
using UnityEngine;

public class Details_View : MonoBehaviour
{
    public TextMeshPro name;
    public TextMeshPro Description;
    public TextMeshPro price;
    public TextMeshPro pe;
    public TextMeshPro div;
    public TextMeshPro income_rise;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        name = GameObject.Find("Details_Screen").transform.GetChild(1).GetComponent<TextMeshPro>();
        Description = GameObject.Find("Description").GetComponent<TextMeshPro>();
        price = GameObject.Find("Details_Screen").transform.GetChild(2).GetComponent<TextMeshPro>();
        pe = GameObject.Find("PE").GetComponent<TextMeshPro>();
        div = GameObject.Find("Div").GetComponent<TextMeshPro>();
        income_rise = GameObject.Find("Income_Rise").GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        name.SetText(Details_Model.current.fields.name);
        price.SetText("Цена:"+Details_Model.current.fields.price);
        pe.SetText("P/E:"+Details_Model.current.fields.pe);
        div.SetText("Див. доход:"+Details_Model.current.fields.divs);
        income_rise.SetText("Годовой рост прибыли:"+Details_Model.current.fields.income_rise);
        Description.SetText("Описание:"+Details_Model.current.fields.description);
    }
}
