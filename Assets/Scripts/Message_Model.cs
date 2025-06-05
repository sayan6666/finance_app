using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Message_Model : MonoBehaviour
{
    public static GameObject Next_Button;
    public static GameObject Exit_Button;
    public static bool is_checked;
    public static List<(string, string, int)> dialogue;

    public static void Buttons_Active()
    {
        Next_Button.SetActive(!Next_Button.activeSelf);
        Exit_Button.SetActive(!Exit_Button.activeSelf);
    }
    public static void AddMessage(string message, int amount, string align, bool seen)
    {
        is_checked = seen;
        if (amount==0)
        GameObject.Find("Message_Origin").GetComponent<TextMeshPro>().SetText("<align="+align+">"+message+"\n");
        else
            GameObject.Find("Message_Origin").GetComponent<TextMeshPro>().SetText(GameObject.Find("Message_Origin").GetComponent<TextMeshPro>().text + "\n\n"+"<align=" + align + ">" + message);
        //Debug.Log(GameObject.Find("Message_Origin").GetComponent<TextMeshPro>().textInfo.lineCount);
        /* var New_Message = GameObject.Instantiate(GameObject.Find("Message_Origin"));
         New_Message.transform .SetParent(GameObject.Find("Message_Screen").transform, true);
         New_Message.GetComponent<TextMeshPro>().SetText(message);
         var Pos_Rot = GameObject.Find("Message_Origin").GetComponent<RectTransform>();
         New_Message.GetComponent<RectTransform>().SetPositionAndRotation(new Vector3(Pos_Rot.position.x,Pos_Rot.position.y-amount, Pos_Rot.position.z),new Quaternion(0,0,0,0));*/
        //New_Message.GetComponent<RectTransform>().rect.Set(0,-0.332f, 81.9185f, 0.665f);
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialogue = new List<(string, string, int)>();
        CreateDialogue();
        is_checked = false;
        Next_Button = GameObject.Find("Next_Button"); ;
        Exit_Button = GameObject.Find("Exit_Message_Button");
        AddMessage(dialogue[0].Item1,0, "left", false); 
        scripte.messages++;
    }

    /*0 - �������� ������ �����
     1 - �������� 1 �������
    2 - �������� ������
    3 - �����*/
    public void CreateDialogue()
    {
        dialogue.Add(("������! ���, ��� �� ����� ������ ���� � ��� ����������. �������������� � ��� ������� ������������� ����� ������� ��� ��������� �������. �� ��� ������ ����� ������� ��������� ������� �������. �����?","left",0));
        dialogue.Add(("��, �����!",  "right",1));
        dialogue.Add(("�������! ����� � ������ ��������. �������������� � ��� �� �� �� �����, ��� ����������. ����� �� ������ ������ �� ���������� ����, ��� ������ ����� ��� � �� ������. � ��� �������������� �������������, ��� �� ����������� ������ � ������, ����� ��� �����, ��������� ��� ������������, � ����� �� �����.", "left", 0));
        dialogue.Add(("�����. � ��� ����� ������?", "right", 1));
        dialogue.Add(("������ � ��� ��, ��� ����� ��������� �������. ��������, ���� �� ��������� ����� ��������, �� ����������� � ����������. ����� �������� ������������, �� ������ �������� ����� ������� � ���� ���������� ��� � ������ ����� ��������� ����� ������� �� �� ������� ����. � ������� ����� ��������� ���������, ������������, ������, ������������ � ������ �������������� �����������.", "left", 0));
        dialogue.Add(("�� ����, � ���� ���������� �� ����� ��������� �����?", "right", 1));
        dialogue.Add(("�����! ���� ��������� ����� � ��� ���� �� �������� ����������. �� ����� ����� �������, ��� ���� ����� ����� � ������. �������������� ������� � �������. ��� ������ ����� ��������, ��� ������� ���������� ������.", "left", 0));
        dialogue.Add(("� ��� �� ������� ���������� ������?", "right", 1));
        dialogue.Add(("������� ������! ���� ��� �������� ������� ������ �������: <b>��������������� ������</b> � <b>����������� ������</b>. ��������������� ������ �������� ������, ��������� �������� ��� ����� ������� � ����� ������ �������� � �������� �����. ����������� ������ � ��� ����� �� �������� ������� � ������� ��������� ���, ����� ����������� ������� ��������.\r\n", "left", 0));
        dialogue.Add(("������ ���������. � ��� ������, ��� ����� �� ������� ������?", "right", 1));
        dialogue.Add(("�������, ��� �� �������! ���� �� �������� ���������� ������� � ��� <b>��������������</b>. ��� ��������, ��� �� �� ������ ���������� ��� ���� ������ � ���� ����� ��� ���� ��������. ����� ������������ �� ����� ���������� ��������, ����� ������� ����� ������.", "left", 0));
        dialogue.Add(("�� ����, ���� ���� ����� �����, ������ ����� ������ �������������� ������?", "right", 1));
        dialogue.Add(("������! ��� ����� ������ ���������.� �����, ��� �������������� � ��� ������������ �������.��� ������ ������� �� ������ ��������� ����� ������� �����, ��� ������ ������ �� �����.", "left", 0));
        dialogue.Add(("������, ��� �������. ��� ��� ������ ������?", "right", 1));
        dialogue.Add(("������ ��� �� ������ �������� �����, ����� ������� ��������� � ���, ��� �������� �������� ��������������, ������� ������� ���� ������� ��������.����� �� �������� �� �����, ����� �������� �������� �� ��������� �������� �����������:\n� <b>���� �����</b>: ��� ��������� ����� ����� ��������.��������, ���� ���� ����� �������� ���������� $50, ��� ��������, ��� ���� ����� ��������� $50, ����� ������ ���� ����� ���� ��������.���� ����� ����� ���������� � ����������� �� ��������� ��������.\n� <b>P / E(Price - to - Earnings)</b>: ��� ����������� ���� / �������.�� ����������, ������� ��������� ������ ������� �� ������ ������ ������� ��������.��������, ���� P / E ����� 15, ��� ������, ��� ��������� ������ ������� $15 �� ������ $1 ������� ��������.��� ���� P / E, ���, ��� �������, ����� ����������� ��������.�� ����� �������, ��� ������� �������� P / E ����� ����������������� � ������� ��������� ����� ��������.\n� <b>����������� ����������</b>: ��� �������, ������� �� ������ �������� �� ���������� � ���� ����������.��������, ���� ����������� ���������� �������� ���������� 4 %, ��� ������, ��� �������� �� ������ �������� 4 % �� ��������� ����� ����� � ���� ����������.��� ����� ��� ����������, ������� ���� ���������� �����.\n� <b>���� ������� �� ��������� ���</b>: ���� ���������� ����������, ��������� ����������� ������� �������� �� ��������� ���.��������, ���� ���� ������� �������� 25 %, ��� ��������, ��� �������� ������ ��������� ���� ������� �� 25 % �� ��������� � ���������� �����.��� ������� ������������ �������������� ��� ������ ���������� ����� ��������.", "left", 1));
        dialogue.Add(("������, ����� �� ����� �������� ��������������, �� ����� ������� � ������ �����.�� ������� ��������� �������� � ������� ������������.���� ������ � ������� ��, �������, �� ���� ������, �������� ���������� �����������. �����?", "left", 0));
        dialogue.Add(("��� ����� ������� �� ������� ����� � ������ ������������� �����. ����� �� ���, ����� ������� �������� �������������� � ��������� ���������� ���������� ��� ������.", "left", 1));
        dialogue.Add(("����� ������� ����� �� ������ ������ ������ ��������� ������� � ������� ���� � ��� �� �������, ��� ��������� � ����!", "left", 3));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
