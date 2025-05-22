using UnityEngine;

public class News_Model : MonoBehaviour
{
    public static GameObject[] Blocks;
    public static News[] News;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Blocks = new GameObject[3];
        News = new News[3];
        for (int i = 0; i < 3; i++)
        {
            Blocks[i] = GameObject.Find("News_Block" + (i+1).ToString());
            News[i] = GameObject.Find("News").GetComponents<News>()[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
