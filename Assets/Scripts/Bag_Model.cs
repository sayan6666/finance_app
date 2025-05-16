using TMPro;
using UnityEditor;
using UnityEngine;

public class Bag_Model : MonoBehaviour
{
    public static GameObject Screen;
    public static Vector3 Screen_Position;
    public static void Screen_Active()
    {
        if (Screen.transform.position == Screen_Position)
            Screen.transform.SetPositionAndRotation(1000 * Screen.transform.position, new Quaternion(0, 0, 0, 0));
        else Screen.transform.SetPositionAndRotation(Screen_Position, new Quaternion(0, 0, 0, 0));
        //Screen.SetActive(!Screen.activeSelf);
    }
    public static void StocksSet()
    {
        GameObject.Find("Bag_Stock1").transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().SetText(Main_Model.GreenTechSolutions.fields.name);
        GameObject.Find("Bag_Stock1").transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().SetText(Main_Model.GreenTechSolutions.fields.amount.ToString()+" רע.");
        GameObject.Find("Bag_Stock1").transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().SetText(Main_Model.GreenTechSolutions.fields.price.ToString()+"$");
        GameObject.Find("Bag_Stock3").transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().SetText(Main_Model.ToxicGoldInc.fields.name);
        GameObject.Find("Bag_Stock3").transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().SetText(Main_Model.ToxicGoldInc.fields.amount.ToString() + " רע.");
        GameObject.Find("Bag_Stock3").transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().SetText(Main_Model.ToxicGoldInc.fields.price.ToString() + "$");
        GameObject.Find("Bag_Stock2").transform.GetChild(0).gameObject.GetComponent<TextMeshPro>().SetText(Main_Model.FashionWave.fields.name);
        GameObject.Find("Bag_Stock2").transform.GetChild(1).gameObject.GetComponent<TextMeshPro>().SetText(Main_Model.FashionWave.fields.amount.ToString() + " רע.");
        GameObject.Find("Bag_Stock2").transform.GetChild(2).gameObject.GetComponent<TextMeshPro>().SetText(Main_Model.FashionWave.fields.price.ToString() + "$");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        Screen = GameObject.Find("Bag_Screen");
        Screen_Position = Screen.transform.position;
        //Screen_Active();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
