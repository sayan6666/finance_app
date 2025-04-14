using TMPro;
using UnityEngine;

public class Main_Model : MonoBehaviour
{
    public static Stock GreenTechSolutions, ToxicGoldInc;
    public static Player Player;

    void StockSet(GameObject obj, Stock stock)
    {
        obj.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().SetText(stock.name);
        obj.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().SetText("Цена:"+stock.price);
        obj.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().SetText("P/E:"+stock.pe);
        obj.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().SetText("Див. доход:"+stock.divs+"%");
        obj.transform.GetChild(4).gameObject.GetComponent<TextMeshPro>().SetText("Рост\nприбыли:"+stock.income_rise+"%");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = GameObject.Find("Player").GetComponent<Player>();
        GreenTechSolutions = new Stock("GreenTech Solutions", "", 50, 15, 4, 25,  GameObject.Find("Stock1"));
        StockSet(GameObject.Find("Stock1"), GreenTechSolutions);
        ToxicGoldInc = new Stock("ToxicGoldInc", "", 5, -15, 0, -50,  GameObject.Find("Stock2"));
        StockSet(GameObject.Find("Stock2"), ToxicGoldInc);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
