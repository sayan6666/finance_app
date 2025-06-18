using UnityEngine;

public class Task : MonoBehaviour
{
    public string text;
    public string title;
    public bool done;
    public bool claimed;
    public int reward;

    public Task(string text, string title, bool done, bool claimed, int reward)
    {
        this.text = text;
        this.title = title;
        this.done = done;
        this.claimed = claimed;
        this.reward = reward;
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
