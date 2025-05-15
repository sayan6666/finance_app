using UnityEngine;

public class Wait_Model : MonoBehaviour
{
    public static void StatsUpdate(int[] price)
    {
        Main_Model.GreenTechSolutions.fields.price = price[0];
        Main_Model.FashionWave.fields.price = price[1];
        Main_Model.ToxicGoldInc.fields.price = price[2];
        Main_Model.StockSet(GameObject.Find(Main_Model.GreenTechSolutions.fields.stock_obj_name), Main_Model.GreenTechSolutions);
        Main_Model.StockSet(GameObject.Find(Main_Model.FashionWave.fields.stock_obj_name), Main_Model.FashionWave);
        Main_Model.StockSet(GameObject.Find(Main_Model.ToxicGoldInc.fields.stock_obj_name), Main_Model.ToxicGoldInc);
    }

    public static void Aftermath(string message)
    {
        Message_Model.AddMessage(message, scripte.messages);
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
