using System;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;
using SQLite4Unity3d;

public class StockList
{
    public StockFields[] stocks = new StockFields[3];
}

[Table("Stocks")]
public class StockFields
{
    public StockFields() { }
    [PrimaryKey, AutoIncrement]
    [Column("id")]
    public int id { get; set; }
    [Column("name")]
    public string name { get; set; }
    [Column("description")]
    public string description { get; set; }
    [Column("price")]
    public int price { get; set; }
    [Column("pe")]
    public int pe { get; set; }
    [Column("divs")]
    public int divs { get; set; }
    [Column("income_rise")]
    public int income_rise { get; set; }
    [Ignore]
    public int status_required { get; set; }
    [Column("amount")]
    public int amount { get; set; } = 0;
    [Column("stock_obj_name")]
    public string stock_obj_name { get; set; }
    [Ignore]
    public Input_Handler input_handler_buy { get; set; }
    [Ignore]
    public Input_Handler input_handler_sell { get; set; }
    [Ignore]
    public Input_Handler input_handler_info1 { get; set; }
    [Ignore]
    public Input_Handler input_handler_info2 { get; set; }
    [Column("advice")]
    public string advice { get; set; }
    [Column("verdict")]
    public int verdict { get; set; }
    [Column("price_diff")]
    public int price_diff { get; set; }

    public StockFields(string name_c, string description_c, int price_c, int pe_c, int divs_c, int income_rise_c/*, int status_required_c*/, string stock_obj_c, string advice, int verdict)
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
        this.verdict = verdict;
        price_diff = 0;
        Retrieve_Obj();
    }

    public void Retrieve_Obj()
    {
        input_handler_buy = GameObject.Find(stock_obj_name).transform.GetChild(2).GetComponent<Input_Handler>();
        input_handler_sell = GameObject.Find("Bag_" + stock_obj_name).transform.GetChild(4).GetComponent<Input_Handler>();
        input_handler_info1 = GameObject.Find(stock_obj_name).transform.GetChild(3).GetComponent<Input_Handler>();
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

    public bool LastWeekAdvice()
    {
        if (fields.amount>0 && Main_Model.stage==1 && Message_Model.dialogue[Message_Controller.message-1].type ==3)
        {
            Message_Model.AddMessage(fields.advice, 4, "left",false);
            scripte.messages+=2;
            Main_Model.verdict = fields.verdict;
            return true;
        } 
        return false;
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
