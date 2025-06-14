using UnityEngine;

public class Task_Model : MonoBehaviour
{
    public static Input_Handler Exit_Action;
    public static int[] marked = new int[1];
    public Sprite Done1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Exit_Action = GameObject.Find("Exit_Button").GetComponent<Input_Handler>();
        marked[0] = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Message_Controller.message == 17)
            GameObject.Find("Task1").transform.SetLocalPositionAndRotation(new Vector3(0, 3.5f, 0), new Quaternion(0, 0, 0, 0));
        if (marked[0]==1)
            GameObject.Find("Task1").GetComponent<SpriteRenderer>().sprite = Done1;
    }
}
