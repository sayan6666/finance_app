using System.Diagnostics;
using TMPro;
using UnityEngine;

public class ND_VIew : MonoBehaviour
{
    public TextMeshPro title;
    public TextMeshPro Description;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        title = GameObject.Find("News_Details_Screen").transform.GetChild(0).GetComponent<TextMeshPro>();
        Description = GameObject.Find("News_Description").GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        title.SetText(ND_Model.current.title);
        Description.SetText(ND_Model.current.description);
    }
}
