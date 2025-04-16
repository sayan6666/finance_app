using UnityEngine;
using UnityEngine.UI;

public class scripte : MonoBehaviour
{
    bool Action = false;
    public static int messages = 1;
    public static Transform button_transform;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button_transform = GameObject.Find("Next_Button").GetComponent<Transform>();
    }

    public static void Move_Button()
    {
        button_transform.SetPositionAndRotation(new Vector3(button_transform.position.x, button_transform.transform.position.y - 1, button_transform.transform.position.z), new Quaternion(0, 0, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if (Action)
        {
            Action = false;
            Message_Model.AddMessage("advice",messages);
            messages++;
            Move_Button();
        }
    }

    public void OnMouseDown()
    {
        Action = true;
    }
}
