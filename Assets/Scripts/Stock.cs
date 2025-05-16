using System;
using System.Xml.Serialization;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

[Serializable]
[XmlRoot("StockList")]
public class StockList
{
    [XmlElement("Stock")]
    public StockFields[] stocks = new StockFields[3];
}

[Serializable]
public class StockFields
{
    [XmlElement("name")]
    public string name { get; set; }
    [XmlElement("description")]
    public string description { get; set; }
    [XmlElement("price")]
    public int price { get; set; }
    [XmlElement("pe")]
    public int pe { get; set; }
    [XmlElement("divs")]
    public int divs { get; set; }
    [XmlElement("income_rise")]
    public int income_rise { get; set; }
    [XmlElement("status_required")]
    public int status_required { get; set; }
    [XmlElement("amount")]
    public int amount = 0;
    [XmlElement("stock_obj")]
    public string stock_obj_name;
    [XmlIgnore]
    public Input_Handler input_handler_buy;
    [XmlIgnore]
    public Input_Handler input_handler_sell;
    [XmlIgnore]
    public Input_Handler input_handler_info1;
    [XmlIgnore]
    public Input_Handler input_handler_info2;
    [XmlElement("advice")]
    public string advice;

    public StockFields(string name_c, string description_c, int price_c, int pe_c, int divs_c, int income_rise_c/*, int status_required_c*/, string stock_obj_c, string advice)
    {
        name = name_c;
        description = description_c;
        price = price_c;
        pe = pe_c;
        divs = divs_c;
        income_rise = income_rise_c;
        status_required = 0;
        stock_obj_name = stock_obj_c;
        this.advice = advice;
        input_handler_buy = GameObject.Find(stock_obj_name).transform.GetChild(2).GetComponent<Input_Handler>();
        input_handler_sell = GameObject.Find("Bag_" + stock_obj_name).transform.GetChild(4).GetComponent<Input_Handler>();
        input_handler_info1=  GameObject.Find(stock_obj_name).transform.GetChild(3).GetComponent<Input_Handler>();
        input_handler_info2 = GameObject.Find("Bag_" + stock_obj_name).transform.GetChild(5).GetComponent<Input_Handler>();
    }
}

[Serializable]
public class Stock : MonoBehaviour
{
    public StockFields fields;

    public Stock() { }

    public void Input_Check()
    {
        //Debug.Log(Player.money);
        if (fields.input_handler_sell.Action && fields.amount>0)
        {
            fields.input_handler_sell.Action = false;
            Player.fields.money = Player.fields.money + fields.price;
            fields.amount--;
        }
        if (fields.input_handler_buy.Action && Player.fields.money>=fields.price)
        {
            fields.input_handler_buy.Action = false;
            Player.fields.money = Player.fields.money - fields.price;
            fields.amount++;
            //Message_Model.AddMessage(fields.advice, scripte.messages);
            //scripte.messages++;
            //scripte.Move_Button();
        }
        if (fields.input_handler_info1.Action /*&& !fields.input_handler_buy.Action*/)
        {
            fields.input_handler_info1.Action = false;
            Details_Model.previous_screen = 2;
            Details_Model.current = this;
            Screen_Changer.Change_Screen(5);
        }
        if (fields.input_handler_info2.Action/* && !fields.input_handler_sell.Action*/)
        {
            fields.input_handler_info2.Action = false;
            Details_Model.previous_screen = 1;
            Details_Model.current = this;
            Screen_Changer.Change_Screen(5);
        }
    }

    public void LastWeekAdvice()
    {
        if (fields.amount>0)
        {
            Message_Model.AddMessage(fields.advice, scripte.messages);
            scripte.messages+=2;
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
