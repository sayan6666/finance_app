using System;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Main_Model : MonoBehaviour
{
    public KeyDownEvent e;
    public Serializer serializer;
    public static GameObject assistant;
    public static Stock GreenTechSolutions, ToxicGoldInc, FashionWave;
    public static StockList Stock_List;
    public static Player Player;
    public static GameObject Screen;
    public static Vector3 Screen_Position;
    public static float timer = 0;
    public static int verdict;

    public static void StockSet(GameObject obj, Stock stock)
    {
        obj.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().SetText(stock.fields.name);
        obj.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().SetText(stock.fields.price+"$");
        /*obj.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().SetText("P/E:"+stock.fields.pe);
        obj.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().SetText("Див. доход:"+stock.fields.divs+"%");
        obj.transform.GetChild(4).gameObject.GetComponent<TextMeshPro>().SetText("Рост\nприбыли:"+stock.fields.income_rise+"%");*/
    }

    public static void Screen_Active()
    {
        if (Screen.transform.position == Screen_Position)
        Screen.transform.SetPositionAndRotation(1000 * Screen.transform.position, new Quaternion(0, 0, 0, 0));
        else Screen.transform.SetPositionAndRotation(Screen_Position, new Quaternion(0, 0, 0, 0));
        //Screen.SetActive(!Screen.activeSelf);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Screen = GameObject.Find("Main_Screen");
        e = new KeyDownEvent();
        serializer = new Serializer();
        Stock_List = new StockList();
        Screen_Position = Screen.transform.position;
        Player = GameObject.Find("Player").GetComponent<Player>();
        assistant = GameObject.Find("NMP");
        verdict = 0;

        Stock_List.stocks[0]= new StockFields("GreenTech Solutions", "Компания, занимающаяся разработкой экологически чистых технологий и альтернативных источников энергии. Недавно они заключили контракт с крупным международным партнером, что может значительно увеличить доходы в будущем. Прогноз роста доходов на следующий год — 20%.", 50, 15, 4, 25, "Stock1", "Отличный выбор! Низкий P/E, высокий рост прибыли и дивиденды — идеально для долгосрочного портфеля. Эта компания явно недооценена!", 1);
        GameObject.Find("Stock").GetComponents<Stock>()[0].fields = Stock_List.stocks[0];
        GreenTechSolutions = GameObject.Find("Stock").GetComponents<Stock>()[0];
        StockSet(GameObject.Find(GreenTechSolutions.fields.stock_obj_name), GreenTechSolutions);

        Stock_List.stocks[1] = new StockFields("FashionWave", "Компания производит модную одежду и аксессуары. В последнее время наблюдается стабилизация доходов, однако рынок становится всё более конкурентным. Хотя спрос на продукцию остаётся, компания сталкивается с трудностями в снижении издержек. Неопределённость относительно дальнейшего роста", 75, 30, 2, 5, "Stock2", "Неплохо, но P/E высоковат для такого умеренного роста. Возможно, есть более выгодные варианты. Советую сравнить с другими акциями.", 0);
        GameObject.Find("Stock").GetComponents<Stock>()[1].fields = Stock_List.stocks[1];
        FashionWave = GameObject.Find("Stock").GetComponents<Stock>()[1];
        StockSet(GameObject.Find(FashionWave.fields.stock_obj_name), FashionWave);

        Stock_List.stocks[2] = new StockFields("ToxicGoldInc", "Компания занимается добычей и переработкой нефти. Однако она столкнулась с серьёзными экологическими и юридическими проблемами, её запасы истощаются, а долговая нагрузка колоссальна. Инвесторы начинают массово продавать акции. Прогнозы на будущее крайне пессимистичны.", 5, -15, 0, -50, "Stock3", "Очень рискованно! У компании отрицательная прибыль и нет дивидендов. Такой выбор может привести к большим потерям. Давай попробуем ещё раз?", -1);
        GameObject.Find("Stock").GetComponents<Stock>()[2].fields = Stock_List.stocks[2];
        ToxicGoldInc = GameObject.Find("Stock").GetComponents<Stock>()[2];
        StockSet(GameObject.Find(ToxicGoldInc.fields.stock_obj_name), ToxicGoldInc);

        Stock_List.stocks[0] = GreenTechSolutions.fields;
        Stock_List.stocks[1] = FashionWave.fields;
        Stock_List.stocks[2]=ToxicGoldInc.fields;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("+");
            serializer.Serialize(Stock_List, "stocklist.xml");
            serializer.Serialize(Player.fields, "player.xml");     
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("++");
            Stock_List =serializer.Deserialize<StockList>("stocklist.xml");
            Player.fields =serializer.Deserialize<PlayerFields>("player.xml");
            //Player.fields.money_display = GameObject.Find("Money").GetComponent<TextMeshPro>();
        }
    }
}
