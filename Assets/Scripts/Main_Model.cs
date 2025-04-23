using TMPro;
using UnityEditor;
using UnityEngine;

public class Main_Model : MonoBehaviour
{
    public static Stock GreenTechSolutions, ToxicGoldInc;
    public static Player Player;
    public static GameObject Screen;
    public static Vector3 Screen_Position;

    void StockSet(GameObject obj, Stock stock)
    {
        obj.transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().SetText(stock.name);
        obj.transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().SetText("Цена:"+stock.price);
        obj.transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().SetText("P/E:"+stock.pe);
        obj.transform.GetChild(3).gameObject.GetComponent<TextMeshPro>().SetText("Див. доход:"+stock.divs+"%");
        obj.transform.GetChild(4).gameObject.GetComponent<TextMeshPro>().SetText("Рост\nприбыли:"+stock.income_rise+"%");
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
        Screen_Position = Screen.transform.position;
        Player = GameObject.Find("Player").GetComponent<Player>();
        GreenTechSolutions = new Stock("GreenTech Solutions", "", 50, 15, 4, 25,  GameObject.Find("Stock1"), "Отличный выбор!");
        StockSet(GreenTechSolutions.stock_obj, GreenTechSolutions);
        ToxicGoldInc = new Stock("ToxicGoldInc", "", 5, -15, 0, -50,  GameObject.Find("Stock2"), "Сомнительное решение");
        StockSet(ToxicGoldInc.stock_obj, ToxicGoldInc);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
