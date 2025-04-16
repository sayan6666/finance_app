using System;
using UnityEngine;

public class Stock : MonoBehaviour
{
    new public string name { get; }
    public string description { get; }
    public int price { get; set; }
    public int pe { get; set; }
    public int divs { get; set; }
    public int income_rise { get; set; }
    public int status_required { get; }
    public GameObject stock_obj;
    public Input_Handler input_handler;
    public string advice;

    public Stock(string name_c, string description_c, int price_c, int pe_c, int divs_c, int income_rise_c/*, int status_required_c*/, GameObject stock_obj_c, string advice)
    {
        name = name_c;
        description = description_c;
        price = price_c;
        pe = pe_c;
        divs = divs_c;
        income_rise = income_rise_c;
        status_required = 0;
        stock_obj = stock_obj_c;
        this.advice = advice;
        input_handler = stock_obj.transform.GetChild(5).GetComponent<Input_Handler>();
    }

    public void Input_Check()
    {
        if (input_handler.Action)
        {
            input_handler.Action = false;
            Player.money = Player.money - price;
            Message_Model.AddMessage(advice, scripte.messages);
            scripte.messages++;
            scripte.Move_Button();
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
