using UnityEngine;

public class News : MonoBehaviour
{
    public int day;
    public string title;
    public string description;
    public bool instanced;

    public News(int day, string title, string description)
    {
        this.day = day;
        this.title = title;
        this.description = description;
        instanced = false;
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
