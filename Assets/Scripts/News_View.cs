using UnityEngine;

public class News_View : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i=0;i<3;i++)
            if (!News_Model.News[i].instanced && Player.fields.day == News_Model.News[i].day)
            {
                News_Model.Blocks[i].transform.SetPositionAndRotation(new Vector3(News_Model.Blocks[i].transform.position.x, News_Model.Blocks[i].transform.position.y - 12, News_Model.Blocks[i].transform.position.z), new Quaternion(0, 0, 0, 0));
                News_Model.News[i].instanced = true;
            }
    }
}
