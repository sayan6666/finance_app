using TMPro;
using System;
using UnityEngine;
using UnityEngine.Rendering;

public class Wait_Model : MonoBehaviour
{
    public static void StatsUpdate(int[] price)
    {
        for (int i = 0;i<3;i++)
        {
            if (price[i] - Main_Model.Stock_List.stocks[i].price > 0)
            {
                GameObject.Find("Bag_Stock" + (i + 1).ToString()).transform.GetChild(3).GetComponent<TextMeshPro>().SetText("+"+(Math.Abs(price[i] - Main_Model.Stock_List.stocks[i].price)).ToString()+"$");
                GameObject.Find("Bag_Stock" + (i + 1).ToString()).transform.GetChild(3).GetComponent<TextMeshPro>().color = Color.green;
            }
            else
            {
                GameObject.Find("Bag_Stock" + (i + 1).ToString()).transform.GetChild(3).GetComponent<TextMeshPro>().SetText("-" + (Math.Abs(price[i] - Main_Model.Stock_List.stocks[i].price)).ToString() + "$");
                GameObject.Find("Bag_Stock" + (i + 1).ToString()).transform.GetChild(3).GetComponent<TextMeshPro>().color = Color.red;
            }
        }
        Main_Model.GreenTechSolutions.fields.price = price[0];
        Main_Model.FashionWave.fields.price = price[1];
        Main_Model.ToxicGoldInc.fields.price = price[2];
        Main_Model.StockSet(GameObject.Find(Main_Model.GreenTechSolutions.fields.stock_obj_name), Main_Model.GreenTechSolutions);
        Main_Model.StockSet(GameObject.Find(Main_Model.FashionWave.fields.stock_obj_name), Main_Model.FashionWave);
        Main_Model.StockSet(GameObject.Find(Main_Model.ToxicGoldInc.fields.stock_obj_name), Main_Model.ToxicGoldInc);
    }

    public static void Aftermath(string message)
    {
        Message_Model.AddMessage(message, 4, "left", false);
        scripte.messages++;
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
